namespace ZendCoreController
{
    partial class main
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
          this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
          this.groupBox1 = new System.Windows.Forms.GroupBox();
          this.label2 = new System.Windows.Forms.Label();
          this.label1 = new System.Windows.Forms.Label();
          this.btnMySQL = new System.Windows.Forms.Button();
          this.btnApache = new System.Windows.Forms.Button();
          this.chkMySQLService = new System.Windows.Forms.CheckBox();
          this.chkApacheService = new System.Windows.Forms.CheckBox();
          this.btnExit = new System.Windows.Forms.Button();
          this.txtStatus = new System.Windows.Forms.TextBox();
          this.label3 = new System.Windows.Forms.Label();
          this.label4 = new System.Windows.Forms.Label();
          this.linkLabel1 = new System.Windows.Forms.LinkLabel();
          this.pictureBox1 = new System.Windows.Forms.PictureBox();
          this.btnRefresh = new System.Windows.Forms.Button();
          this.lblApacheStatus = new System.Windows.Forms.Label();
          this.lblMySQLStatus = new System.Windows.Forms.Label();
          this.refreshTimer = new System.Windows.Forms.Timer(this.components);
          this.groupBox1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
          this.SuspendLayout();
          // 
          // notifyIcon
          // 
          this.notifyIcon.Text = "Zend Core Controller";
          this.notifyIcon.Visible = true;
          this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
          this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
          // 
          // groupBox1
          // 
          this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.groupBox1.Controls.Add(this.lblMySQLStatus);
          this.groupBox1.Controls.Add(this.lblApacheStatus);
          this.groupBox1.Controls.Add(this.label2);
          this.groupBox1.Controls.Add(this.label1);
          this.groupBox1.Controls.Add(this.btnMySQL);
          this.groupBox1.Controls.Add(this.btnApache);
          this.groupBox1.Controls.Add(this.chkMySQLService);
          this.groupBox1.Controls.Add(this.chkApacheService);
          this.groupBox1.Location = new System.Drawing.Point(12, 66);
          this.groupBox1.Name = "groupBox1";
          this.groupBox1.Size = new System.Drawing.Size(311, 84);
          this.groupBox1.TabIndex = 6;
          this.groupBox1.TabStop = false;
          this.groupBox1.Text = "Modules";
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(62, 55);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(42, 13);
          this.label2.TabIndex = 11;
          this.label2.Text = "MySQL";
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(62, 26);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(44, 13);
          this.label1.TabIndex = 10;
          this.label1.Text = "Apache";
          // 
          // btnMySQL
          // 
          this.btnMySQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.btnMySQL.Location = new System.Drawing.Point(224, 50);
          this.btnMySQL.Name = "btnMySQL";
          this.btnMySQL.Size = new System.Drawing.Size(75, 23);
          this.btnMySQL.TabIndex = 9;
          this.btnMySQL.Text = "Start";
          this.btnMySQL.UseVisualStyleBackColor = true;
          this.btnMySQL.Click += new System.EventHandler(this.btnMySQL_Click);
          // 
          // btnApache
          // 
          this.btnApache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.btnApache.Location = new System.Drawing.Point(224, 21);
          this.btnApache.Name = "btnApache";
          this.btnApache.Size = new System.Drawing.Size(75, 23);
          this.btnApache.TabIndex = 8;
          this.btnApache.Text = "Start";
          this.btnApache.UseVisualStyleBackColor = true;
          this.btnApache.Click += new System.EventHandler(this.btnApache_Click);
          // 
          // chkMySQLService
          // 
          this.chkMySQLService.AutoSize = true;
          this.chkMySQLService.Location = new System.Drawing.Point(11, 54);
          this.chkMySQLService.Name = "chkMySQLService";
          this.chkMySQLService.Size = new System.Drawing.Size(45, 17);
          this.chkMySQLService.TabIndex = 7;
          this.chkMySQLService.Text = "Svc";
          this.chkMySQLService.UseVisualStyleBackColor = true;
          // 
          // chkApacheService
          // 
          this.chkApacheService.AutoSize = true;
          this.chkApacheService.Location = new System.Drawing.Point(11, 25);
          this.chkApacheService.Name = "chkApacheService";
          this.chkApacheService.Size = new System.Drawing.Size(45, 17);
          this.chkApacheService.TabIndex = 6;
          this.chkApacheService.Text = "Svc";
          this.chkApacheService.UseVisualStyleBackColor = true;
          // 
          // btnExit
          // 
          this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.btnExit.Location = new System.Drawing.Point(335, 121);
          this.btnExit.Name = "btnExit";
          this.btnExit.Size = new System.Drawing.Size(75, 23);
          this.btnExit.TabIndex = 8;
          this.btnExit.Text = "E&xit";
          this.btnExit.UseVisualStyleBackColor = true;
          this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
          // 
          // txtStatus
          // 
          this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.txtStatus.BackColor = System.Drawing.Color.White;
          this.txtStatus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.txtStatus.Location = new System.Drawing.Point(12, 156);
          this.txtStatus.Multiline = true;
          this.txtStatus.Name = "txtStatus";
          this.txtStatus.ReadOnly = true;
          this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
          this.txtStatus.Size = new System.Drawing.Size(397, 155);
          this.txtStatus.TabIndex = 9;
          this.txtStatus.WordWrap = false;
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(63, 12);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(104, 13);
          this.label3.TabIndex = 10;
          this.label3.Text = "Zend Core Controller";
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.Location = new System.Drawing.Point(63, 29);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(120, 13);
          this.label4.TabIndex = 11;
          this.label4.Text = "Created by Mike Smullin";
          // 
          // linkLabel1
          // 
          this.linkLabel1.AutoSize = true;
          this.linkLabel1.Location = new System.Drawing.Point(63, 46);
          this.linkLabel1.Name = "linkLabel1";
          this.linkLabel1.Size = new System.Drawing.Size(146, 13);
          this.linkLabel1.TabIndex = 12;
          this.linkLabel1.TabStop = true;
          this.linkLabel1.Text = "http://www.mikesmullin.com/";
          // 
          // pictureBox1
          // 
          this.pictureBox1.Image = global::ZendCoreController.Properties.Resources.core_48x48;
          this.pictureBox1.Location = new System.Drawing.Point(12, 12);
          this.pictureBox1.Name = "pictureBox1";
          this.pictureBox1.Size = new System.Drawing.Size(48, 48);
          this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
          this.pictureBox1.TabIndex = 13;
          this.pictureBox1.TabStop = false;
          // 
          // btnRefresh
          // 
          this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.btnRefresh.Location = new System.Drawing.Point(335, 91);
          this.btnRefresh.Name = "btnRefresh";
          this.btnRefresh.Size = new System.Drawing.Size(75, 23);
          this.btnRefresh.TabIndex = 14;
          this.btnRefresh.Text = "&Refresh";
          this.btnRefresh.UseVisualStyleBackColor = true;
          this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
          // 
          // lblApacheStatus
          // 
          this.lblApacheStatus.AutoSize = true;
          this.lblApacheStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
          this.lblApacheStatus.Location = new System.Drawing.Point(120, 26);
          this.lblApacheStatus.Name = "lblApacheStatus";
          this.lblApacheStatus.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
          this.lblApacheStatus.Size = new System.Drawing.Size(63, 15);
          this.lblApacheStatus.TabIndex = 15;
          this.lblApacheStatus.Text = "Running";
          this.lblApacheStatus.Visible = false;
          // 
          // lblMySQLStatus
          // 
          this.lblMySQLStatus.AutoSize = true;
          this.lblMySQLStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
          this.lblMySQLStatus.Location = new System.Drawing.Point(120, 55);
          this.lblMySQLStatus.Name = "lblMySQLStatus";
          this.lblMySQLStatus.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
          this.lblMySQLStatus.Size = new System.Drawing.Size(63, 15);
          this.lblMySQLStatus.TabIndex = 17;
          this.lblMySQLStatus.Text = "Running";
          this.lblMySQLStatus.Visible = false;
          // 
          // refreshTimer
          // 
          this.refreshTimer.Enabled = true;
          this.refreshTimer.Interval = 5000;
          this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
          // 
          // main
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(421, 323);
          this.Controls.Add(this.btnRefresh);
          this.Controls.Add(this.pictureBox1);
          this.Controls.Add(this.linkLabel1);
          this.Controls.Add(this.label4);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.txtStatus);
          this.Controls.Add(this.btnExit);
          this.Controls.Add(this.groupBox1);
          this.MinimumSize = new System.Drawing.Size(429, 357);
          this.Name = "main";
          this.Text = "Zend Core Controller";
          this.Load += new System.EventHandler(this.main_Load);
          this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
          this.Resize += new System.EventHandler(this.main_Resize);
          this.groupBox1.ResumeLayout(false);
          this.groupBox1.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMySQL;
        private System.Windows.Forms.Button btnApache;
        private System.Windows.Forms.CheckBox chkMySQLService;
        private System.Windows.Forms.CheckBox chkApacheService;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblMySQLStatus;
        private System.Windows.Forms.Label lblApacheStatus;
        private System.Windows.Forms.Timer refreshTimer;
    }
}

