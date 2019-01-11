using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


namespace SMS
{
    public class Program
    {

        static void Main(string[] args)
        {

            
            const string accountSid = "ACe78c1bbd72cc1da74d2277f5d8d9ea97";
            const string authToken = "bf7612619dca0adb3412474d9cf42e20";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "4455",
                from: new Twilio.Types.PhoneNumber("+18646332809"),
                to: new Twilio.Types.PhoneNumber("+77784717809")
            );

            Console.WriteLine(message.Sid);
        }

        
    }
    
    


}

