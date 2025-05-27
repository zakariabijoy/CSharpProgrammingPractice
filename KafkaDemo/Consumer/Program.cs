using Confluent.Kafka;
using System.Collections.Concurrent;

var config = new ConsumerConfig
{
    // User-specific properties that you must set
    BootstrapServers = "localhost:9092",

    // Fixed properties
    GroupId = "kafka-dotnet-exam-consumer",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

const string topic = "exam-events";

// Optional: Track last event per student (for demonstration)
var studentEventLog = new ConcurrentDictionary<string, List<string>>();

CancellationTokenSource cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, e) => {
    e.Cancel = true; // prevent the process from terminating.
    cts.Cancel();
};

using (var consumer = new ConsumerBuilder<string, string>(config).Build())
{
    consumer.Subscribe(topic);
    try
    {
        while (true)
        {
            var cr = consumer.Consume(cts.Token);

            // Log event per student
            studentEventLog.AddOrUpdate(
                cr.Message.Key,
                new List<string> { cr.Message.Value },
                (key, list) => { list.Add(cr.Message.Value); return list; }
            );

            Console.WriteLine(
                $"Student: {cr.Message.Key,-10} | Event: {cr.Message.Value,-8} | Partition: {cr.Partition} | Offset: {cr.Offset}"
            );

            // Optional: Print all events for this student so far
            Console.WriteLine($"Events for {cr.Message.Key}: {string.Join(", ", studentEventLog[cr.Message.Key])}");
        }
    }
    catch (OperationCanceledException)
    {
        // Ctrl-C was pressed.
    }
    finally
    {
        consumer.Close();
    }
}
