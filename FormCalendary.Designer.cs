
namespace STlamia1._1
{
    partial class FormCalendary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendary));
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.DownInfoPanel = new System.Windows.Forms.Panel();
            this.ReferensLink = new System.Windows.Forms.LinkLabel();
            this.DifficultInfo = new System.Windows.Forms.Label();
            this.TimeInfo = new System.Windows.Forms.Label();
            this.ReferensLabel = new System.Windows.Forms.Label();
            this.DifficultLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.UpInfoPanel = new System.Windows.Forms.Panel();
            this.ServingInfoPanel = new System.Windows.Forms.Panel();
            this.MainInfoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelUp = new System.Windows.Forms.Panel();
            this.VerCorrect = new System.Windows.Forms.Label();
            this.OKBut = new System.Windows.Forms.Button();
            this.Mskmonth = new System.Windows.Forms.MaskedTextBox();
            this.Mskyear = new System.Windows.Forms.MaskedTextBox();
            this.LastBut = new System.Windows.Forms.Button();
            this.ReturnNowBut = new System.Windows.Forms.Button();
            this.NextBut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Calendary = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelInfo.SuspendLayout();
            this.DownInfoPanel.SuspendLayout();
            this.UpInfoPanel.SuspendLayout();
            this.MainInfoPanel.SuspendLayout();
            this.PanelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelInfo
            // 
            this.PanelInfo.AutoScroll = true;
            this.PanelInfo.BackColor = System.Drawing.Color.Transparent;
            this.PanelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInfo.Controls.Add(this.DownInfoPanel);
            this.PanelInfo.Controls.Add(this.UpInfoPanel);
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInfo.Location = new System.Drawing.Point(0, 0);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(695, 187);
            this.PanelInfo.TabIndex = 0;
            // 
            // DownInfoPanel
            // 
            this.DownInfoPanel.Controls.Add(this.ReferensLink);
            this.DownInfoPanel.Controls.Add(this.DifficultInfo);
            this.DownInfoPanel.Controls.Add(this.TimeInfo);
            this.DownInfoPanel.Controls.Add(this.ReferensLabel);
            this.DownInfoPanel.Controls.Add(this.DifficultLabel);
            this.DownInfoPanel.Controls.Add(this.TimeLabel);
            this.DownInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownInfoPanel.Location = new System.Drawing.Point(0, 59);
            this.DownInfoPanel.Name = "DownInfoPanel";
            this.DownInfoPanel.Size = new System.Drawing.Size(693, 126);
            this.DownInfoPanel.TabIndex = 1;
            // 
            // ReferensLink
            // 
            this.ReferensLink.AutoSize = true;
            this.ReferensLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReferensLink.LinkColor = System.Drawing.Color.Fuchsia;
            this.ReferensLink.Location = new System.Drawing.Point(464, 27);
            this.ReferensLink.Name = "ReferensLink";
            this.ReferensLink.Size = new System.Drawing.Size(36, 16);
            this.ReferensLink.TabIndex = 1;
            this.ReferensLink.TabStop = true;
            this.ReferensLink.Text = "Non";
            this.ReferensLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReferensLink_LinkClicked);
            // 
            // DifficultInfo
            // 
            this.DifficultInfo.AutoSize = true;
            this.DifficultInfo.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultInfo.ForeColor = System.Drawing.Color.LightCoral;
            this.DifficultInfo.Location = new System.Drawing.Point(146, 70);
            this.DifficultInfo.Name = "DifficultInfo";
            this.DifficultInfo.Size = new System.Drawing.Size(52, 24);
            this.DifficultInfo.TabIndex = 0;
            this.DifficultInfo.Text = "000";
            // 
            // TimeInfo
            // 
            this.TimeInfo.AutoSize = true;
            this.TimeInfo.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInfo.ForeColor = System.Drawing.Color.LightCoral;
            this.TimeInfo.Location = new System.Drawing.Point(124, 24);
            this.TimeInfo.Name = "TimeInfo";
            this.TimeInfo.Size = new System.Drawing.Size(73, 24);
            this.TimeInfo.TabIndex = 0;
            this.TimeInfo.Text = "00:00";
            // 
            // ReferensLabel
            // 
            this.ReferensLabel.AutoSize = true;
            this.ReferensLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferensLabel.Location = new System.Drawing.Point(357, 20);
            this.ReferensLabel.Name = "ReferensLabel";
            this.ReferensLabel.Size = new System.Drawing.Size(106, 26);
            this.ReferensLabel.TabIndex = 0;
            this.ReferensLabel.Text = "Ссылка:";
            // 
            // DifficultLabel
            // 
            this.DifficultLabel.AutoSize = true;
            this.DifficultLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultLabel.Location = new System.Drawing.Point(11, 67);
            this.DifficultLabel.Name = "DifficultLabel";
            this.DifficultLabel.Size = new System.Drawing.Size(138, 26);
            this.DifficultLabel.TabIndex = 0;
            this.DifficultLabel.Text = "Сложность:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(38, 20);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(89, 26);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Время:";
            // 
            // UpInfoPanel
            // 
            this.UpInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpInfoPanel.Controls.Add(this.ServingInfoPanel);
            this.UpInfoPanel.Controls.Add(this.MainInfoPanel);
            this.UpInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.UpInfoPanel.Name = "UpInfoPanel";
            this.UpInfoPanel.Size = new System.Drawing.Size(693, 59);
            this.UpInfoPanel.TabIndex = 0;
            // 
            // ServingInfoPanel
            // 
            this.ServingInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServingInfoPanel.Location = new System.Drawing.Point(122, 0);
            this.ServingInfoPanel.Name = "ServingInfoPanel";
            this.ServingInfoPanel.Size = new System.Drawing.Size(569, 57);
            this.ServingInfoPanel.TabIndex = 1;
            // 
            // MainInfoPanel
            // 
            this.MainInfoPanel.Controls.Add(this.label2);
            this.MainInfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.MainInfoPanel.Name = "MainInfoPanel";
            this.MainInfoPanel.Size = new System.Drawing.Size(122, 57);
            this.MainInfoPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "Задачи";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelUp
            // 
            this.PanelUp.BackColor = System.Drawing.Color.Transparent;
            this.PanelUp.Controls.Add(this.VerCorrect);
            this.PanelUp.Controls.Add(this.OKBut);
            this.PanelUp.Controls.Add(this.Mskmonth);
            this.PanelUp.Controls.Add(this.Mskyear);
            this.PanelUp.Controls.Add(this.LastBut);
            this.PanelUp.Controls.Add(this.ReturnNowBut);
            this.PanelUp.Controls.Add(this.NextBut);
            this.PanelUp.Controls.Add(this.label8);
            this.PanelUp.Controls.Add(this.label7);
            this.PanelUp.Controls.Add(this.label6);
            this.PanelUp.Controls.Add(this.label5);
            this.PanelUp.Controls.Add(this.label4);
            this.PanelUp.Controls.Add(this.label3);
            this.PanelUp.Controls.Add(this.label1);
            this.PanelUp.Controls.Add(this.Calendary);
            this.PanelUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUp.Location = new System.Drawing.Point(0, 187);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(695, 369);
            this.PanelUp.TabIndex = 1;
            // 
            // VerCorrect
            // 
            this.VerCorrect.AutoSize = true;
            this.VerCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VerCorrect.ForeColor = System.Drawing.Color.Red;
            this.VerCorrect.Location = new System.Drawing.Point(221, 11);
            this.VerCorrect.Name = "VerCorrect";
            this.VerCorrect.Size = new System.Drawing.Size(190, 20);
            this.VerCorrect.TabIndex = 16;
            this.VerCorrect.Text = "*Error no correct date*";
            this.VerCorrect.Visible = false;
            // 
            // OKBut
            // 
            this.OKBut.FlatAppearance.BorderSize = 0;
            this.OKBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKBut.Location = new System.Drawing.Point(140, 19);
            this.OKBut.Name = "OKBut";
            this.OKBut.Size = new System.Drawing.Size(75, 30);
            this.OKBut.TabIndex = 15;
            this.OKBut.Text = "OK";
            this.OKBut.UseVisualStyleBackColor = true;
            this.OKBut.Click += new System.EventHandler(this.OKBut_Click);
            // 
            // Mskmonth
            // 
            this.Mskmonth.BackColor = System.Drawing.Color.Teal;
            this.Mskmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mskmonth.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mskmonth.Location = new System.Drawing.Point(98, 19);
            this.Mskmonth.Mask = "00";
            this.Mskmonth.Name = "Mskmonth";
            this.Mskmonth.PromptChar = 'Y';
            this.Mskmonth.Size = new System.Drawing.Size(36, 30);
            this.Mskmonth.TabIndex = 14;
            this.Mskmonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mskmonth.ValidatingType = typeof(System.DateTime);
            // 
            // Mskyear
            // 
            this.Mskyear.BackColor = System.Drawing.Color.Teal;
            this.Mskyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mskyear.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mskyear.Location = new System.Drawing.Point(13, 19);
            this.Mskyear.Mask = "0000";
            this.Mskyear.Name = "Mskyear";
            this.Mskyear.PromptChar = 'X';
            this.Mskyear.Size = new System.Drawing.Size(67, 30);
            this.Mskyear.TabIndex = 13;
            this.Mskyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mskyear.ValidatingType = typeof(System.DateTime);
            // 
            // LastBut
            // 
            this.LastBut.FlatAppearance.BorderSize = 0;
            this.LastBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastBut.Location = new System.Drawing.Point(528, 11);
            this.LastBut.Name = "LastBut";
            this.LastBut.Size = new System.Drawing.Size(52, 38);
            this.LastBut.TabIndex = 12;
            this.LastBut.Text = "<";
            this.LastBut.UseVisualStyleBackColor = true;
            this.LastBut.Click += new System.EventHandler(this.LastBut_Click);
            // 
            // ReturnNowBut
            // 
            this.ReturnNowBut.FlatAppearance.BorderSize = 0;
            this.ReturnNowBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnNowBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnNowBut.Location = new System.Drawing.Point(577, 11);
            this.ReturnNowBut.Name = "ReturnNowBut";
            this.ReturnNowBut.Size = new System.Drawing.Size(69, 38);
            this.ReturnNowBut.TabIndex = 11;
            this.ReturnNowBut.Text = "Now";
            this.ReturnNowBut.UseVisualStyleBackColor = true;
            this.ReturnNowBut.Click += new System.EventHandler(this.ReturnNowBut_Click);
            // 
            // NextBut
            // 
            this.NextBut.FlatAppearance.BorderSize = 0;
            this.NextBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextBut.Location = new System.Drawing.Point(643, 11);
            this.NextBut.Name = "NextBut";
            this.NextBut.Size = new System.Drawing.Size(52, 38);
            this.NextBut.TabIndex = 10;
            this.NextBut.Text = ">";
            this.NextBut.UseVisualStyleBackColor = true;
            this.NextBut.Click += new System.EventHandler(this.NextBut_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(626, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "Вс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(523, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Сб";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Пт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Чт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ср";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пн";
            // 
            // Calendary
            // 
            this.Calendary.Location = new System.Drawing.Point(0, 94);
            this.Calendary.Name = "Calendary";
            this.Calendary.Size = new System.Drawing.Size(695, 275);
            this.Calendary.TabIndex = 0;
            // 
            // FormCalendary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 556);
            this.Controls.Add(this.PanelUp);
            this.Controls.Add(this.PanelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCalendary";
            this.Text = "FormCalendary";
            this.Load += new System.EventHandler(this.FormCalendary_Load);
            this.PanelInfo.ResumeLayout(false);
            this.DownInfoPanel.ResumeLayout(false);
            this.DownInfoPanel.PerformLayout();
            this.UpInfoPanel.ResumeLayout(false);
            this.MainInfoPanel.ResumeLayout(false);
            this.PanelUp.ResumeLayout(false);
            this.PanelUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Panel PanelUp;
        private System.Windows.Forms.FlowLayoutPanel Calendary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Mskmonth;
        private System.Windows.Forms.MaskedTextBox Mskyear;
        private System.Windows.Forms.Button LastBut;
        private System.Windows.Forms.Button ReturnNowBut;
        private System.Windows.Forms.Button NextBut;
        private System.Windows.Forms.Button OKBut;
        private System.Windows.Forms.Label VerCorrect;
        private System.Windows.Forms.Panel DownInfoPanel;
        private System.Windows.Forms.Panel UpInfoPanel;
        private System.Windows.Forms.Panel ServingInfoPanel;
        private System.Windows.Forms.Panel MainInfoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeInfo;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DifficultInfo;
        private System.Windows.Forms.Label DifficultLabel;
        private System.Windows.Forms.LinkLabel ReferensLink;
        private System.Windows.Forms.Label ReferensLabel;
    }
}