using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using WorkerServiceWithQuartz;
using WorkerServiceWithQuartz.JobFactory;
using WorkerServiceWithQuartz.Jobs;
using WorkerServiceWithQuartz.Models;
using WorkerServiceWithQuartz.Schedular;

var environmentName = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
var configuration = new ConfigurationBuilder()
     .SetBasePath(Directory.GetCurrentDirectory())
     .AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true)
     .AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true).AddEnvironmentVariables();

var config = configuration.Build();

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        //services.AddHostedService<Worker>();

        services.AddSingleton<IJobFactory, MyJobFactory>();
        services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();

        #region Adding JobType
        services.AddSingleton<NotificationJob>();
        services.AddSingleton<LoggerJob>();
        
        #endregion

        #region Adding Jobs 
        List<JobMetadata> jobMetadatas = new List<JobMetadata>();
        jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(NotificationJob), config["Jobs:Notification:Name"], config["Jobs:Notification:Cron"]));
        jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(LoggerJob), config["Jobs:Logger:Name"], config["Jobs:Logger:Cron"]));

        services.AddSingleton(jobMetadatas);
        #endregion

        services.AddHostedService<MySchedular>();
    })
    .Build();

await host.RunAsync();
