namespace ynetMivzakim
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.refresh = new System.Windows.Forms.Button();
            this.lstatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.animationsTimer = new System.Windows.Forms.Timer(this.components);
            this.imgprogressPic = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.news = new ynetMivzakim.feedItemsView();
            this.newsProcessorView1 = new ynetMivzakim.newsProcessorView();
            this.progressPic = new System.Windows.Forms.Panel();
            this.jokeView1 = new ynetMivzakim.jokeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.graph1 = new ynetMivzakim.Graph();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgprogressPic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.progressPic.SuspendLayout();
            this.panel2.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.refresh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstatus, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 29);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // refresh
            // 
            this.refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(460, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(54, 23);
            this.refresh.TabIndex = 0;
            this.toolTip1.SetToolTip(this.refresh, "Refresh Info");
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // lstatus
            // 
            this.lstatus.AutoSize = true;
            this.lstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstatus.Location = new System.Drawing.Point(340, 0);
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(114, 29);
            this.lstatus.TabIndex = 1;
            this.lstatus.Text = "last Updated: - ";
            this.lstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // animationsTimer
            // 
            this.animationsTimer.Tick += new System.EventHandler(this.animationsTimer_Tick);
            // 
            // imgprogressPic
            // 
            this.imgprogressPic.BackColor = System.Drawing.Color.Transparent;
            this.imgprogressPic.Image = ((System.Drawing.Image)(resources.GetObject("imgprogressPic.Image")));
            this.imgprogressPic.Location = new System.Drawing.Point(3, 3);
            this.imgprogressPic.Name = "imgprogressPic";
            this.imgprogressPic.Size = new System.Drawing.Size(128, 128);
            this.imgprogressPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgprogressPic.TabIndex = 2;
            this.imgprogressPic.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.processToolStripMenuItem.Text = "Process!";
            this.processToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.news);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(517, 499);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 6;
            // 
            // news
            // 
            this.news.ContextMenuStrip = this.contextMenuStrip1;
            this.news.Dock = System.Windows.Forms.DockStyle.Fill;
            this.news.feedInfo = null;
            this.news.Location = new System.Drawing.Point(0, 0);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(517, 172);
            this.news.TabIndex = 3;
            // 
            // newsProcessorView1
            // 
            this.newsProcessorView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsProcessorView1.Location = new System.Drawing.Point(0, 0);
            this.newsProcessorView1.Name = "newsProcessorView1";
            this.newsProcessorView1.ProcessResult = null;
            this.newsProcessorView1.Size = new System.Drawing.Size(259, 323);
            this.newsProcessorView1.TabIndex = 5;
            // 
            // progressPic
            // 
            this.progressPic.Controls.Add(this.jokeView1);
            this.progressPic.Controls.Add(this.panel2);
            this.progressPic.Location = new System.Drawing.Point(0, 30);
            this.progressPic.Name = "progressPic";
            this.progressPic.Size = new System.Drawing.Size(416, 387);
            this.progressPic.TabIndex = 4;
            // 
            // jokeView1
            // 
            this.jokeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jokeView1.Location = new System.Drawing.Point(0, 133);
            this.jokeView1.Name = "jokeView1";
            this.jokeView1.Size = new System.Drawing.Size(416, 254);
            this.jokeView1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imgprogressPic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 133);
            this.panel2.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.newsProcessorView1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.graph1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(517, 323);
            this.splitContainer2.SplitterDistance = 259;
            this.splitContainer2.TabIndex = 6;
            // 
            // graph1
            // 
            this.graph1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graph1.Location = new System.Drawing.Point(0, 0);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(254, 323);
            this.graph1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 528);
            this.Controls.Add(this.progressPic);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Very Simple News Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgprogressPic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.progressPic.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lstatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer animationsTimer;
        private System.Windows.Forms.PictureBox imgprogressPic;
        private feedItemsView news;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private newsProcessorView newsProcessorView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel progressPic;
        private jokeView jokeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Graph graph1;
    }
}

