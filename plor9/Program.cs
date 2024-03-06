using System;
using System.Collections.Generic;


namespace plor9
{
    internal static class Program
    {
        static void Main()
        {
            NotificationContainer<SMSNotification> SMSContainer = new();
            NotificationContainer<EmailNotification> EmailContainer = new();
            NotificationContainer<PushNotification> PushContainer = new();

            SMSNotification smsNot = new("sender1", "content1");
            SMSNotification smsNot2 = new("sender2", "content2");
            EmailNotification emailNot = new("sender1", "content1", "Image");
            PushNotification pushNot = new("sender1", "content1", "VK");


            SMSContainer.Add(smsNot2);
            SMSContainer.Add(smsNot);
            EmailContainer.Add(emailNot);
            PushContainer.Add(pushNot);

            List<SMSNotification> smsList = SMSContainer.GetNotification();
            List<EmailNotification> emailList = EmailContainer.GetNotification();
            List<PushNotification> pushList = PushContainer.GetNotification();


            smsList[0].GetInfo();
            smsList[1].GetInfo();
            emailList[0].GetInfo();
            pushList[0].GetInfo();

            SMSContainer.GetNotificationCount();
            EmailContainer.GetNotificationCount();
            PushContainer.GetNotificationCount();

            Console.WriteLine();

            smsList.Sort();
            smsList[0].GetInfo();
            smsList[1].GetInfo();
        }
    }

    abstract class Notification : IComparable<Notification>
    {
        protected string sender;
        protected string content;
        protected DateTime send_time;

        public string WhoSend()
        {
            return sender;
        }

        public void Read()
        {
            Console.WriteLine(content);
        }

        public abstract void GetInfo();

        public int CompareTo(Notification notf)
        {
            return sender.CompareTo(notf.sender);
        }
    }


    class SMSNotification : Notification
    {
        public override void GetInfo()
        {
            Console.WriteLine($"SMS Notification\nSend time: {send_time}\nSender: {sender}\nContent: {content}\n");
        }

        public SMSNotification(string sender, string content)
        {
            this.sender = sender;
            this.content = content;
        }
    }

    class EmailNotification : Notification
    {
        private string attachment_type;

        public override void GetInfo()
        {
            Console.WriteLine($"Email Notification\nSend time: {send_time}\nSender: {sender}\nContent: {content}\nAttachment type: {attachment_type}\n");
        }

        public EmailNotification(string sender, string content, string attachment_type)
        {
            this.sender = sender;
            this.content = content;
            this.attachment_type = attachment_type;
        }
    }

    class PushNotification : Notification
    {
        private string programm;

        public override void GetInfo()
        {
            Console.WriteLine($"Push Notification\nSend time: {send_time}\nSender: {sender}\nContent: {content}\nProgramm: {programm}\n");
        }

        public PushNotification(string sender, string content, string programm)
        {
            this.sender = sender;
            this.content = content;
            this.programm = programm;
        }

    }


    class NotificationContainer<T>
    {
        private List<T> notifications = new List<T>();

        public void Add(T notf)
        {
            notifications.Add(notf);
        }

        public List<T> GetNotification()
        {
            return notifications;
        }

        public void GetNotificationCount()
        {
            Console.WriteLine(notifications.Count);
        }
    }
}
