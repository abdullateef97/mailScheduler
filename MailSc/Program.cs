using System;
using System.Data.Entity;
using System.Linq;
using MailSc.Data;

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
        }


    }
}