using System.Collections.Generic;
using System.Linq;
using MailSc.Models;

namespace MailSc.Data
{
    public class DbInitializer
    {
        public static void Initialize(MailContext mailContext)
        {
            mailContext.Database.EnsureCreated();

            if (!mailContext.Emails.Any())
            {
                var emails = new Email[]
                {
                    new Email {EmailAddress = "adeniranyusufabdullateef@gmail.com", Name = "Abdullateef"},
                    new Email {EmailAddress = "adeniranyusufabdullateef@gmail.com", Name = "Belle_meee"}
                };
                foreach (var e in emails)
                {
                    mailContext.Add(e);
                }
                mailContext.SaveChanges();
            }
        }
    }
}