using System;

namespace mocktestEvents
{
    class Program
    {
        public  delegate void Noti(string msg);
        public static event Noti MsgSender;
        
        static void Main(string[] args)
        {
            MsgSender += EmailSender;
            MsgSender += EmailMarketing;
            MsgSender.Invoke("muba pagol");
        }

        static void EmailSender(string msg)
        {
            Console.WriteLine($"from emailsender: {msg}");
        }

        static void EmailMarketing(string msg)
        {
            Console.WriteLine($"from emailmarkting: {msg}");
        }
    }
}
