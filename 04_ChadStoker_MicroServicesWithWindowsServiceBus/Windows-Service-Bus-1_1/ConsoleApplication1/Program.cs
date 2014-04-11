using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        public static string _sbConnString = ConfigurationManager.AppSettings["sbConnString"];

        static void Main(string[] args)
        {   
            SubscriptionClient pubSubClient = SubscriptionClient.CreateFromConnectionString(
                _sbConnString, 
                "ChadTopic", 
                "MyListeningApp", 
                ReceiveMode.PeekLock);

            Thread t = new Thread(() =>
            {
                WaitForMessage(pubSubClient);

            }) { IsBackground = true };

            t.Start();

            Console.ReadLine();
        }

        private static void WaitForMessage(SubscriptionClient pubSubClient)
        {
            pubSubClient.BeginReceive((c) =>
            {
                if (c.IsCompleted)
                {
                    BrokeredMessage msg = pubSubClient.EndReceive(c);
                    try
                    {
                        Stream str = msg.GetBody<Stream>();
                        TestData test = Deserialize<TestData>(str);
                        Console.WriteLine("It worked! " + test.Text);
                        msg.Complete();
                    }
                    catch(Exception ex)
                    {
                        msg.DeadLetter("ProblemProcessingMessage", ex.ToString());
                    }

                    WaitForMessage(pubSubClient);
                }
            }, null);
        }


        public static T Deserialize<T>(Stream str)
        {
            XmlSerializer xSer = new XmlSerializer(typeof(T));
            return (T)xSer.Deserialize(str);
        }
    }
}
