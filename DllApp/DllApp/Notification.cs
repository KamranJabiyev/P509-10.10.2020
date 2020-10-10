using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllApp
{
    public class Notification
    {
        public int Id { get; set; }
        protected internal int MyProperty { get; set; }
        private protected string Message { get; set; }

        public void Test()
        {
            Console.WriteLine(Message);
        }

    }

    internal class SmsNotification:Notification
    {
        public SmsNotification()
        {
            Message = "Salam";
            Console.WriteLine(Message);
        }
    }

    public class SendSms
    {

    }


    class Test
    {
        Notification not = new Notification();
        public Test()
        {
            not.Id = 5;
            not.MyProperty = 10;
            not.Id = not.MyProperty;
        }
    }
}
