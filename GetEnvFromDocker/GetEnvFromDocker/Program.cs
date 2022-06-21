using Microsoft.Extensions.Configuration;


var environmentName = "Development"/* Environment.GetEnvironmentVariable("DotNet_ENVIRONMENT")*/;
var configBuilder  = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile($"appsettings.json", true, true)
                    .AddJsonFile($"appsettings.{environmentName}.json", true, true)
                    .AddEnvironmentVariables();

// Load configurations
IConfigurationRoot configuration = configBuilder.Build();

Console.WriteLine(configuration["connectionString"]);
var counter = 0;
var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
while (max == -1 || counter < max)
{
    Console.WriteLine($"Counter: {++counter}");
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}

