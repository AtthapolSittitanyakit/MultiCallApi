using MultiCallApi.Dtos;
using MultiCallApi.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace MultiCallApi
{
    class Program
    {
        public static List<Task> TaskList = new List<Task>();

        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
          
            var genXml = DataCall.xml_call();


            var temp = new List<string>();
            
            foreach (var item in genXml)
            {
                using (var stringwriter = new System.IO.StringWriter())
                {
                    var serializer = new XmlSerializer(item.GetType());
                    serializer.Serialize(stringwriter, item);

                    temp.Add(stringwriter.ToString());
                    TaskList.Add(Program.Call(stringwriter.ToString()));

                   
                }
            }

            //Task task0 = await Task.Factory.StartNew(() => Program.Call(temp[0])).ConfigureAwait(false);
            //Task task1 = Task.Factory.StartNew(() => Program.Call(temp[1]));
            //Task task2 = Task.Factory.StartNew(() => Program.Call(temp[2]));
            //Task task3 = Task.Factory.StartNew(() => Program.Call(temp[3]));
            //Task task4 = Task.Factory.StartNew(() => Program.Call(temp[4]));
            //Task task5 = Task.Factory.StartNew(() => Program.Call(temp[5]));
            //Task task6 = Task.Factory.StartNew(() => Program.Call(temp[6]));
            //Task task7 = Task.Factory.StartNew(() => Program.Call(temp[7]));
            //Task task8 = Task.Factory.StartNew(() => Program.Call(temp[8]));
            //Task task9 = Task.Factory.StartNew(() => Program.Call(temp[9]));


            //Task task0 = Task.Factory.StartNew(() => Program.Call(temp[0]));
            //Task task1 = Task.Factory.StartNew(() => Program.Call(temp[1]));
            //Task task2 = Task.Factory.StartNew(() => Program.Call(temp[2]));
            //Task task3 = Task.Factory.StartNew(() => Program.Call(temp[3]));
            //Task task4 = Task.Factory.StartNew(() => Program.Call(temp[4]));
            //Task task5 = Task.Factory.StartNew(() => Program.Call(temp[5]));
            //Task task6 = Task.Factory.StartNew(() => Program.Call(temp[6]));
            //Task task7 = Task.Factory.StartNew(() => Program.Call(temp[7]));
            //Task task8 = Task.Factory.StartNew(() => Program.Call(temp[8]));
            //Task task9 = Task.Factory.StartNew(() => Program.Call(temp[9]));

            Task.WaitAll(TaskList.ToArray());

            watch.Stop();

            var times = watch.ElapsedMilliseconds;

            Console.ReadLine();

        }
        
       public static async Task Call(string requestXml)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            var _url = "http://localhost:55957/PMCServices.asmx";
            var _action = "http://tempuri.org/SendPolicy";

            XmlDocument soapEnvelopeXml = CreateSoapEnvelope(requestXml);
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);


            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
            asyncResult.AsyncWaitHandle.WaitOne();


            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.WriteLine(soapResult);
                Console.WriteLine("--------------------------------------------------------------------------------------");
                var times = watch.ElapsedMilliseconds;
                using (StreamWriter writer = new StreamWriter($"D:\\MultiCallApi\\Sample{DateTime.Now.ToString("HHmmssffff")}.txt"))
                {
                    writer.WriteLine(times);
                   
                }
                // Read a file  
               // File.ReadAllText(@"D:\MultiCallApi");
              
            }


        }
        //public static string RemoveAllNamespaces(string xmlDocument)
        //{
        //    XElement xmlDocumentWithoutNs = RemoveAllNamespaces(XElement.Parse(xmlDocument));

        //    return xmlDocumentWithoutNs.ToString();
        //}

        ////Core recursion function
        //private static XElement RemoveAllNamespaces(XElement xmlDocument)
        //{
        //    if (!xmlDocument.HasElements)
        //    {
        //        XElement xElement = new XElement(xmlDocument.Name.LocalName);
        //        xElement.Value = xmlDocument.Value;

        //        foreach (XAttribute attribute in xmlDocument.Attributes())
        //            xElement.Add(attribute);

        //        return xElement;
        //    }
        //    return new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNamespaces(el)));
        //}
        private static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", "http://tempuri.org/SendPolicy");
            webRequest.ContentType = "text/xml;charset='utf-8'";
            webRequest.Accept = " text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope(string requestXml)
        {
            int index = requestXml.IndexOf(System.Environment.NewLine);
            requestXml = requestXml.Substring(index + System.Environment.NewLine.Length);
            int index2 = requestXml.IndexOf(System.Environment.NewLine);
            requestXml = requestXml.Substring(index2 + System.Environment.NewLine.Length);
            requestXml = "<tem:SendPolicy>" + requestXml;




            string xmlData = $@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" 
               xmlns:tem=""http://tempuri.org/"">
        <soapenv:Header/>
        <soapenv:Body>
        {requestXml}
        </soapenv:Body>
    </soapenv:Envelope>";
            XmlDocument soapEnvelopeDocument = new XmlDocument();
           
            soapEnvelopeDocument.LoadXml(xmlData
          );
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            //{
                soapEnvelopeXml.Save(stream);
            }
        }
    }

