using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MailSc.Data;
using Quartz;
using Quartz.Impl;

namespace MailSc
{
    class Program
    {
        private readonly MailContext _context;

        public Program(MailContext context)
        {
            _context = context;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Start();
        }

        private static async  void Start()
        {
           IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();

            var job = JobBuilder.Create<mailJob>().Build();
            var trigger = TriggerBuilder.Create()
                .WithIdentity("mailJob", "mail")
                .WithCronSchedule("	0 0 0 1/1 * ? *")
                .StartAt(DateTime.UtcNow)
                .WithPriority(1)
                .Build();
           await scheduler.ScheduleJob(job, trigger);

                
        }
    }
}