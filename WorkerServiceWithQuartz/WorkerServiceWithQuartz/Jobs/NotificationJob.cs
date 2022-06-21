﻿using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerServiceWithQuartz.Jobs
{
    internal class NotificationJob : IJob
    {
        private readonly ILogger<NotificationJob> _logger;
        public NotificationJob(ILogger<NotificationJob> logger)
        {
            this._logger = logger;
        }
        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation($"Notification Job: Notify User at {DateTime.Now} and Jobtype: {context.JobDetail.JobType}");
            return Task.CompletedTask;
        }
    }
}
