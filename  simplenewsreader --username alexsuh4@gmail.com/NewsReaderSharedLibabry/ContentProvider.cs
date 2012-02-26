using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Net;
using System.IO;
using System.Drawing;

namespace NewsReaderSharedLibabry
{
   public class ContentProvider
    {
        public static List<Event> GetDataScreenScrap()
        {
            string body = Utils.GetBody("http://www.ynet.co.il/home/0,7340,L-184,00.html");
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(body);
            HtmlAgilityPack.HtmlNode root = doc.DocumentNode;
            HtmlAgilityPack.HtmlNodeCollection nodes = root.SelectNodes("/html[1]/body/div[4]/table[3]/tr/td[2]/table[2]/tr/td/table/tr/td/table");
            if (nodes == null || nodes.Count == 0)
                return null;
            HtmlAgilityPack.HtmlNode table = nodes.ElementAt(0);
            List<string> events =
            (from t in table.SelectNodes("tr")
             where !string.IsNullOrEmpty(t.InnerText.Trim()) && !t.InnerText.Contains("מבזקים")
             select t.InnerText).ToList();
            return
                 (from t in table.SelectNodes("tr")
                  where !string.IsNullOrEmpty(t.InnerText.Trim()) && !t.InnerText.Contains("מבזקים")
                  select Event.FromHtmlNode(t)).ToList();

        }
        static TimeSpan maxTimeout = new TimeSpan(0, 0, 30);
        public static FeedINfo GetData()
        {
            //List<ItemInfo> result = new List<Event>();
            XmlDocument doc = null;
            if (File.Exists("StoryRss1854.xml"))
            {
                try
                {
                    doc = new XmlDocument();
                    doc.Load("StoryRss1854.xml");
                }
                catch (Exception)
                {
                    doc = null;
                    File.Delete("StoryRss1854.xml");
                }
            }
            if(File.Exists("StoryRss1854.xml") && DateTime.Now.Subtract(File.GetCreationTime("StoryRss1854.xml")).TotalSeconds > maxTimeout.TotalSeconds)
            {
                doc = null;
                File.Delete("StoryRss1854.xml");
            }
            if (!File.Exists("StoryRss1854.xml"))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://www.ynet.co.il/Integration/StoryRss1854.xml", @"StoryRss1854.xml");
            }
            if (doc == null)
            {
                doc = new XmlDocument();
                doc.Load("StoryRss1854.xml");
            }
            FeedINfo info = FeedInfoUtils.createFromRssXml(doc);

            return info;
            //List<Event>
        }
   }
   public class FeedInfoUtils
   {
       public static FeedINfo createFromRssXml(XmlDocument doc)
       {
           FeedINfo result = new FeedINfo();
           XmlNode root = doc.DocumentElement;
           result.title = root.SelectSingleNode("channel/title").InnerText;
           result.link= root.SelectSingleNode("channel/link").InnerText;
           result.description = root.SelectSingleNode("channel/description").InnerText;
           result.copyright = root.SelectSingleNode("channel/copyright").InnerText;
           result.language = root.SelectSingleNode("channel/language").InnerText;
           result.pubDate = Convert.ToDateTime(root.SelectSingleNode("channel/pubDate").InnerText);
           result.lastBuildDate = Convert.ToDateTime(root.SelectSingleNode("channel/lastBuildDate ").InnerText);

           result.image = CreateImageInfoFromXmlNode(root.SelectSingleNode("channel/image"));
           result.items = CreateItemInfoListFromXmlNodes(root.SelectNodes("//channel/item"));
           return result;
       }

       private static List<ItemInfo> CreateItemInfoListFromXmlNodes(XmlNodeList nodes)
       {
           List<ItemInfo> result = new List<ItemInfo>();
           foreach (XmlNode node in nodes)
           {
               result.Add(CreateItemInfoFromXmlNode(node));
           }
           return result;
       }

       private static ItemInfo CreateItemInfoFromXmlNode(XmlNode root)
       {
           ItemInfo result = new ItemInfo();
           result.category = root.SelectSingleNode("category ").InnerText;
           result.title = root.SelectSingleNode("title ").InnerText;
           result.description = root.SelectSingleNode("description").InnerText;
           result.link = root.SelectSingleNode("link").InnerText;
           result.pubDate = Convert.ToDateTime(root.SelectSingleNode("pubDate").InnerText);
           result.guid = root.SelectSingleNode("guid").InnerText;
           return result;
       }

       

       private static FeedImageInfo CreateImageInfoFromXmlNode(XmlNode root)
       {
           FeedImageInfo result = new FeedImageInfo();
           result.link = root.SelectSingleNode("link").InnerText;
           result.title= root.SelectSingleNode("title").InnerText;
           result.url = root.SelectSingleNode("url").InnerText;
           result.image=ImageLoadHandler.GetImage(result.url);
           if(result.image==null)
                result.image=ImageLoadHandler.GetImage(result.link);
           return result;
       }
       public static class ImageLoadHandler
       {
           public static List<string> imageFileTypes = new List<string>()
           {
               "gif"
               ,"png"
               ,"jpeg"
               ,"jpg"
               ,"bmp"
           };
           internal static Image GetImage(string url)
           {
               try
               {
                   if (!IsImage(url)) return null;
                   Image cachedImage = GetCachedImage(url);
                   if (cachedImage!=null)return cachedImage;
                   
                   Image img=Utils.byteArrayToImage(new WebClient().DownloadData(url));
                   if (img != null)
                       CacheImage(img,url);
                   return img;
               }
               catch (Exception)
               {
                   return null;
               }
           }

           private static void CacheImage(Image img,string url)
           {
               string hashedFileName = GetHashedFileName(url);
               File.WriteAllBytes(hashedFileName, Utils.imageToByteArray(img));
           }

           private static Image GetCachedImage(string url)
           {
               string hashedFileName = GetHashedFileName(url);
               if (File.Exists(hashedFileName))
               {
                   return Utils.byteArrayToImage(File.ReadAllBytes(hashedFileName));
               }
               else return null;
           }

           private static string GetHashedFileName(string url)
           {
               System.Security.Cryptography.MD5CryptoServiceProvider provider =
                              new System.Security.Cryptography.MD5CryptoServiceProvider();
               string extension = getExtension(url);

                return 
               Convert.ToBase64String(
               provider.ComputeHash(new System.Text.UTF8Encoding().GetBytes(url))) + "." + extension;
           }

           private static string getExtension(string url)
           {
               string revString = Utils.ReverseString(url);
               if (url.IndexOf(".") > 0)
                   return
                       Utils.ReverseString(
                       revString.Substring(0, revString.IndexOf(".")));
               return "unknown";
           }

           private static bool IsImage(string url)
           {
               string lower_url = url.ToLower();
               foreach (string ext in imageFileTypes)
               {
                   if (lower_url.EndsWith("." + ext))
                       return true;
               }
               return false;
           }
           public class Utils
           {
               public static string ReverseString(string s)
               {
                   char[] arr = s.ToCharArray();
                   Array.Reverse(arr);
                   return new string(arr);
               }

               public static byte[] imageToByteArray(System.Drawing.Image imageIn)
               {
                   
                   MemoryStream ms = new MemoryStream();
                   imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                   return ms.ToArray();
               }
               public static Image byteArrayToImage(byte[] byteArrayIn)
               {
                   MemoryStream ms = new MemoryStream(byteArrayIn);
                   Image returnImage = Image.FromStream(ms);
                   return returnImage;
               }
           }
       }
   }
   public class FeedINfo
   {
       public string title { get; set; }
       public string link { get; set; }
       public string description { get; set; }
       public string copyright { get; set; }
       public string language { get; set; }
       public DateTime pubDate { get; set; }
       public DateTime lastBuildDate { get; set; }
       public FeedImageInfo image  {get;set;}
       public List<ItemInfo> items { get; set; }
   }
   public class FeedImageInfo
   {
       public string title { get; set; }
       public string link { get; set; }
       public string url { get; set; }
       public Image image { get; set; }
   }
   public class ItemInfo
   {
       public string category { get; set; }
       public string title { get; set; }
       public string description { get; set; }
       public string link { get; set; }
       public DateTime pubDate { get; set; }
       public string guid { get; set; }
   }
    
    
    
    public class Event
    {
        public static Event FromHtmlNode(HtmlAgilityPack.HtmlNode tr)
        {
            Event evt = new Event();
            try
            {
                string href = "";
                HtmlAgilityPack.HtmlNode link = tr.SelectSingleNode(".//a[1]");
                if (link != null)
                    href = "http://www.ynet.co.il" + link.Attributes["href"].Value;
                string text = tr.InnerHtml.Substring(0, tr.InnerHtml.IndexOf("<br>"));
                string datetime = tr.InnerHtml.Substring(tr.InnerHtml.IndexOf("<br>") + "<br>".Length);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(text);
                text = HttpUtility.HtmlDecode(doc.DocumentNode.InnerText);
                doc.LoadHtml(datetime);
                datetime = doc.DocumentNode.InnerText;
                evt.Text = text;
                evt.Time = ToDateTime(datetime);
                evt.RefUrl = href;
                evt.KeyWords = SetKeyWords(text);
            }
            catch (Exception exp) { }
            return evt;

        }

        private static List<string> SetKeyWords(string text)
        {
            return text.Split(' ').ToList();
        }

        private static DateTime ToDateTime(string datetime)
        {

            string[] parts = datetime.Replace("(", "").Replace(")", "").Split(',');
            string[] dateParts=parts[1].Split('.');
            DateTime time = DateTime.Parse(parts[0]);
            //would not work at >3000 AD
            DateTime date = new DateTime(2000 + int.Parse(dateParts[2]), int.Parse(dateParts[1]), int.Parse(dateParts[2]));
            return DateTime.Parse(string.Format("{0} {1}", date.ToString("yyyy-MM-dd"), time.ToString("HH:mm")));
            //string combined = string.Format("{0} {1}", date.ToString("yyyyMMdd"), date.ToString("HHmm"));
            //return DateTime.Now;
        }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public string Display { get { return Time.ToString("(dd.MM.yyyy HH:mm") + ") " + Text; } }
        public string RefUrl { get; set; }
        public Event This { get { return this; } }
        public List<string> KeyWords { get; private set; }
    }
}
