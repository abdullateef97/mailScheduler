using System.Linq;
using MailSc.Data;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace MailSc{
    public class mailJob : IJob
    {

        private readonly MailContext _context;
        public mailJob(MailContext context)
        {
            _context = context;
        }
        public void Execute(IJobExecutionContext context)
        {
            FetchUsersAndSendMail();
        }
        
        public void FetchUsersAndSendMail()
        {
            var users = _context.Emails.AsNoTracking().ToList();
            foreach (var user in users)
            {
                new MailHelper().sendMail(user);
            }
        }
    }
}