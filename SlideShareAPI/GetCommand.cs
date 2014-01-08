using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using System;

namespace SlideShareAPI
{
    public static class GetCommand
    {
        private static XmlSerializer _serializer = new XmlSerializer(typeof(Slideshows));

        public static string ExecuteRaw(string url, ICollection<KeyValuePair<string, object>> parameters)
        {
            var request = WebRequest.Create(url + "?" + Helper.CreateFormattedRequest(parameters)) as HttpWebRequest;
            string responseXml;

            using (var response = request.GetResponse() as HttpWebResponse)
            {
                var reader = new StreamReader(response.GetResponseStream());
                responseXml = reader.ReadToEnd();
            }

            return responseXml;
        }

        public static Slideshows Execute(string url, ICollection<KeyValuePair<string, object>> parameters)
        {
            Slideshows shows = null;

            var request = WebRequest.Create(url + "?" + Helper.CreateFormattedRequest(parameters)) as HttpWebRequest;

            using (var response = request.GetResponse() as HttpWebResponse)
            {
                var reader = new StreamReader(response.GetResponseStream());
                shows = (Slideshows)_serializer.Deserialize(reader);
            }

            return shows;
        }
    }
}
