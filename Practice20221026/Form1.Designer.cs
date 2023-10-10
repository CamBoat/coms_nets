namespace App_Coms_Nets
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnServer = new System.Windows.Forms.Button();
            this.btnStartWork = new System.Windows.Forms.Button();
            this.txtServers = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.txtComs = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbx_S_N = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.White;
            this.btnServer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnServer.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnServer.ForeColor = System.Drawing.Color.Black;
            this.btnServer.Location = new System.Drawing.Point(1, 46);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(265, 34);
            this.btnServer.TabIndex = 7;
            this.btnServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnStartWork
            // 
            this.btnStartWork.BackColor = System.Drawing.Color.Black;
            this.btnStartWork.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartWork.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnStartWork.Location = new System.Drawing.Point(345, 1);
            this.btnStartWork.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartWork.Name = "btnStartWork";
            this.btnStartWork.Size = new System.Drawing.Size(87, 39);
            this.btnStartWork.TabIndex = 2;
            this.btnStartWork.Text = "START";
            this.btnStartWork.UseVisualStyleBackColor = false;
            this.btnStartWork.Click += new System.EventHandler(this.btnStartWork_Click);
            // 
            // txtServers
            // 
            this.txtServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServers.Location = new System.Drawing.Point(1, 81);
            this.txtServers.Multiline = true;
            this.txtServers.Name = "txtServers";
            this.txtServers.Size = new System.Drawing.Size(265, 34);
            this.txtServers.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(432, 41);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "coms checked:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtComs
            // 
            this.txtComs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComs.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtComs.ForeColor = System.Drawing.Color.Green;
            this.txtComs.Location = new System.Drawing.Point(108, 3);
            this.txtComs.Multiline = true;
            this.txtComs.Name = "txtComs";
            this.txtComs.Size = new System.Drawing.Size(236, 36);
            this.txtComs.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::App_Coms_Nets.Properties.Resources.pumb;
            this.pictureBox1.Location = new System.Drawing.Point(267, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tbx_S_N
            // 
            this.tbx_S_N.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_S_N.BackColor = System.Drawing.Color.DarkGreen;
            this.tbx_S_N.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_S_N.ForeColor = System.Drawing.Color.White;
            this.tbx_S_N.Location = new System.Drawing.Point(1, 117);
            this.tbx_S_N.Multiline = true;
            this.tbx_S_N.Name = "tbx_S_N";
            this.tbx_S_N.Size = new System.Drawing.Size(265, 54);
            this.tbx_S_N.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 176);
            this.Controls.Add(this.btnStartWork);
            this.Controls.Add(this.tbx_S_N);
            this.Controls.Add(this.txtServers);
            this.Controls.Add(this.txtComs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transfer data from each com to all net nodes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnStartWork;
        private System.Windows.Forms.TextBox txtServers;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtComs;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox tbx_S_N;


    }
}

