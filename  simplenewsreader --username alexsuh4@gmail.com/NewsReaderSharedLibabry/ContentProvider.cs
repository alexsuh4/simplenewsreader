using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace NewsReaderSharedLibabry
{
   public class ContentProvider
    {
        public static List<Event> GetData()
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
