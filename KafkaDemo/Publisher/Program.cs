using Confluent.Kafka;

const string topic = "exam-events";

//To ensure that messages (such as "pen up" events) for each individual student are delivered in order using Kafka, you should use the student ID as the message key when producing messages. Kafka guarantees ordering per partition, and all messages with the same key are sent to the same partition, preserving their order.
string[] studentIds = { "stu001", "stu002", "stu003" };
string[] events = { "pen_up", "pen_down" };

var config = new ProducerConfig
{
    // User-specific properties that you must set
    BootstrapServers = "localhost:9092",

    // Fixed properties
    Acks = Acks.All
};

using (var producer = new ProducerBuilder<string, string>(config).Build())
{
    Random rnd = new Random();
    const int numMessages = 10;
    for (int i = 0; i < numMessages; ++i)
    {
        var studentId = studentIds[rnd.Next(studentIds.Length)];
        var examEvent = events[rnd.Next(events.Length)];

        producer.Produce(topic, new Message<string, string> { Key = studentId, Value = examEvent },
            (deliveryReport) =>
            {
                if (deliveryReport.Error.Code != ErrorCode.NoError)
                {
                    Console.WriteLine($"Failed to deliver message: {deliveryReport.Error.Reason}");
                }
                else
                {
                    Console.WriteLine($"Produced event to topic {topic}: studentId = {studentId,-10} event = {examEvent}");
                }
            });
    }

    producer.Flush(TimeSpan.FromSeconds(10));
}