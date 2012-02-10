using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace NewsReaderSharedLibabry
{
    public class Utils
    {
        public static string GetBody(string url)
        {

            string uri = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

            WebResponse response = request.GetResponse();
            string body = "";
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                body = stream.ReadToEnd();
            }
            return body;

        }
    }
}
