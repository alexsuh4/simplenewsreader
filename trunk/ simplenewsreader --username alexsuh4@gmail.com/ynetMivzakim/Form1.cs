using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using System.Diagnostics;
using NewsReaderSharedLibabry;

namespace ynetMivzakim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
                RefreshView();

           
        }

        private void RefreshView()
        {
            StartWaiting();
            backgroundWorker2.RunWorkerAsync();
            //try
            //{
           
            //List<Event> evts = ContentProvider.GetData();
            //news.DataSource = null;
            //news.DataSource = evts;
            //news.DisplayMember = "Display";
            //news.ValueMember = "This";
            //lastUpdated = DateTime.Now;
            //lstatus.Text = string.Format("Updated: {0}", lastUpdated.ToString("HH:mm"));
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show("Dooh! " + exp.Message, "Dooh! ");
            //}
        }

        private void StartWaiting()
        {
            lstatus.Text = "Please wait";
            refresh.Enabled = false;
            progressPic.Visible = true;
            animationsTimer.Start();
        }

        
        
        public DateTime lastUpdated=DateTime.Now;
        

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshView();
        }

       

        private void news_DoubleClick(object sender, EventArgs e)
        {
            Event evt = news.SelectedValue as Event;
            if (evt == null && !string.IsNullOrEmpty(evt.RefUrl)) return;
            Process.Start(evt.RefUrl);
        }

        private void news_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result=ContentProvider.GetData();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StopWaiting();
            if (e.Error != null)
            {
                MessageBox.Show("Error :-( " + e.Error.Message); return;
            }
            if (e.Cancelled) return;
            List<Event> evts = (List<Event>)e.Result;
            news.DataSource = null;
            news.DataSource = evts;
            news.DisplayMember = "Display";
            news.ValueMember = "This";
            lastUpdated = DateTime.Now;
            lstatus.Text = string.Format("Updated: {0}", lastUpdated.ToString("HH:mm"));
            
            
        }

        private void StopWaiting()
        {
            refresh.Enabled = true;
            progressPic.Visible = false;
            animationsTimer.Stop();
        }
        int dots = 0;
        int maxdots= 10;

        private void animationsTimer_Tick(object sender, EventArgs e)
        {
            string dotsstr = "";
            dots = (dots + 1) % maxdots;
            for (int i = 0; i < dots; i++)
            {
                dotsstr += ".";
            }
            lstatus.Text =
            lstatus.Text.Replace(".", "") + dotsstr;
            this.Invalidate();
        }


    }
}
