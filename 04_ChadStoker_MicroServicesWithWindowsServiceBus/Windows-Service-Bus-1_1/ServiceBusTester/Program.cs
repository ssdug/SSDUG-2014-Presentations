using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.ServiceBus.Notifications;
using ServiceBusTester.ProxyModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ServiceBusTester
{
    class Program
    {
        public static string _sbConnString = ConfigurationManager.AppSettings["Microsoft.ServiceBus.ConnectionString"];
        static void Main(string[] args)
        {
            string test = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Chat xmlns=\"http://windowsazure.cat.microsoft.com/samples/multicast\"><nickname>Paolo</nickname><text>Hello mate!</text></Chat>";
            Deserialize<TestData>(test);



            ServiceBusConnectionStringBuilder connBuilder = new ServiceBusConnectionStringBuilder(_sbConnString);
            NamespaceManager nsManager = NamespaceManager.Create();
            MessagingFactory msgFactory = MessagingFactory.Create();


            Thread t = new Thread(() =>
            {
                SubscriptionClient tmpNotifier = SubscriptionClient.CreateFromConnectionString(_sbConnString, "testtopic", "TestTopicSubscription1", ReceiveMode.PeekLock);
                WaitForMessage(tmpNotifier);
            });
            t.IsBackground = true; 

            t.Start();


            //string qName = "firstTestQueue";

            //QueueDescription qDesc = null;
            //if (!nsManager.QueueExists(qName))
            //    qDesc = nsManager.CreateQueue(qName);
            //else
            //    qDesc = nsManager.GetQueue(qName);
            
            //if (nsManager.QueueExists(qName))
            //{
            //    DateTime dtCreated = qDesc.CreatedAt;

            //    Console.WriteLine(dtCreated);
            //}
            //else
            //    Console.WriteLine("Not able to locate the queue!");
            Console.ReadLine();
        }

        private static void WaitForMessage(SubscriptionClient tmpNotifier)
        {
            tmpNotifier.BeginReceive((o) =>
            {
                if (o.IsCompleted)
                {
                    Console.WriteLine("This worked! I received a message of some type!");
                    //System.Diagnostics.Debugger.Break();
                    using (BrokeredMessage msg = tmpNotifier.EndReceive(o))
                    {
                        IDictionary<string, object> msgProperties = msg.Properties;
                        string messageId = msg.MessageId;
                        string sessionId = msg.SessionId;
                        string msgLabel = msg.Label;

                        try
                        {
                            Stream msgStream = msg.GetBody<Stream>();
                            TestData messageInfo = Deserialize<TestData>(msgStream);
 
                            msg.Complete();
                        }
                        catch (Exception ex)
                        {
                            msg.DeadLetter("MessageBodyFailure", "Attempt to retrieve the Message-Body failed!");
                        }
                    }
                }

                WaitForMessage(tmpNotifier);
            }, null);
        }

        private static T Deserialize<T>(Stream input)
        {
            StreamReader sReader = new StreamReader(input, Encoding.UTF8);
            string msgBody = sReader.ReadToEnd();
            return Deserialize<T>(msgBody);
        }

        private static T Deserialize<T>(string test)
        {
            XmlSerializer xSer = new XmlSerializer(typeof(T));
            StringReader sr = new StringReader(test);
            XmlReader xr = XmlReader.Create(sr);
            return (T)xSer.Deserialize(xr);
        }
    }
}
