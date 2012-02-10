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
            this.news = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.refresh = new System.Windows.Forms.Button();
            this.lstatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.animationsTimer = new System.Windows.Forms.Timer(this.components);
            this.progressPic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressPic)).BeginInit();
            this.SuspendLayout();
            // 
            // news
            // 
            this.news.Dock = System.Windows.Forms.DockStyle.Fill;
            this.news.FormattingEnabled = true;
            this.news.Location = new System.Drawing.Point(0, 29);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(517, 498);
            this.news.TabIndex = 0;
            this.news.DoubleClick += new System.EventHandler(this.news_DoubleClick);
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
            // progressPic
            // 
            this.progressPic.BackColor = System.Drawing.Color.Transparent;
            this.progressPic.Image = ((System.Drawing.Image)(resources.GetObject("progressPic.Image")));
            this.progressPic.Location = new System.Drawing.Point(197, 117);
            this.progressPic.Name = "progressPic";
            this.progressPic.Size = new System.Drawing.Size(128, 128);
            this.progressPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.progressPic.TabIndex = 2;
            this.progressPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 528);
            this.Controls.Add(this.progressPic);
            this.Controls.Add(this.news);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Very Simple News Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox news;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lstatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer animationsTimer;
        private System.Windows.Forms.PictureBox progressPic;
    }
}

