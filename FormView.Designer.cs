
namespace STlamia1._1
{
    partial class FormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
            this.ListPanel = new System.Windows.Forms.Panel();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.ReCount = new System.Windows.Forms.Button();
            this.LastBut = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.TextBox();
            this.NextBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.ReloadBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TaskInfo = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.DataInfo = new System.Windows.Forms.Label();
            this.ToolPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 114);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(695, 442);
            this.ListPanel.TabIndex = 1;
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolPanel.Controls.Add(this.ReCount);
            this.ToolPanel.Controls.Add(this.LastBut);
            this.ToolPanel.Controls.Add(this.CountLabel);
            this.ToolPanel.Controls.Add(this.NextBut);
            this.ToolPanel.Controls.Add(this.AddBut);
            this.ToolPanel.Controls.Add(this.ReloadBut);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(695, 51);
            this.ToolPanel.TabIndex = 0;
            // 
            // ReCount
            // 
            this.ReCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReCount.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReCount.Location = new System.Drawing.Point(408, 0);
            this.ReCount.Name = "ReCount";
            this.ReCount.Size = new System.Drawing.Size(83, 51);
            this.ReCount.TabIndex = 16;
            this.ReCount.Text = "ОК";
            this.ReCount.UseVisualStyleBackColor = true;
            this.ReCount.Click += new System.EventHandler(this.ReCount_Click);
            // 
            // LastBut
            // 
            this.LastBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.LastBut.FlatAppearance.BorderSize = 0;
            this.LastBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LastBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastBut.Location = new System.Drawing.Point(491, 0);
            this.LastBut.Name = "LastBut";
            this.LastBut.Size = new System.Drawing.Size(75, 51);
            this.LastBut.TabIndex = 15;
            this.LastBut.TabStop = false;
            this.LastBut.Text = "<";
            this.LastBut.UseVisualStyleBackColor = true;
            this.LastBut.Click += new System.EventHandler(this.LastBut_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.BackColor = System.Drawing.Color.HotPink;
            this.CountLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CountLabel.Font = new System.Drawing.Font("Meiryo UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CountLabel.Location = new System.Drawing.Point(566, 0);
            this.CountLabel.MaxLength = 3;
            this.CountLabel.Multiline = true;
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.ShortcutsEnabled = false;
            this.CountLabel.Size = new System.Drawing.Size(54, 51);
            this.CountLabel.TabIndex = 3;
            this.CountLabel.TabStop = false;
            this.CountLabel.Text = "1";
            this.CountLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NextBut
            // 
            this.NextBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextBut.FlatAppearance.BorderSize = 0;
            this.NextBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextBut.Location = new System.Drawing.Point(620, 0);
            this.NextBut.Name = "NextBut";
            this.NextBut.Size = new System.Drawing.Size(75, 51);
            this.NextBut.TabIndex = 13;
            this.NextBut.TabStop = false;
            this.NextBut.Text = ">";
            this.NextBut.UseVisualStyleBackColor = true;
            this.NextBut.Click += new System.EventHandler(this.NextBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.BackColor = System.Drawing.Color.Transparent;
            this.AddBut.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddBut.FlatAppearance.BorderSize = 0;
            this.AddBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBut.ForeColor = System.Drawing.Color.SpringGreen;
            this.AddBut.Location = new System.Drawing.Point(128, 0);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(97, 51);
            this.AddBut.TabIndex = 2;
            this.AddBut.TabStop = false;
            this.AddBut.Text = "+";
            this.AddBut.UseVisualStyleBackColor = false;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // ReloadBut
            // 
            this.ReloadBut.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReloadBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReloadBut.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadBut.Location = new System.Drawing.Point(0, 0);
            this.ReloadBut.Name = "ReloadBut";
            this.ReloadBut.Size = new System.Drawing.Size(128, 51);
            this.ReloadBut.TabIndex = 3;
            this.ReloadBut.TabStop = false;
            this.ReloadBut.Text = "Reload";
            this.ReloadBut.UseVisualStyleBackColor = true;
            this.ReloadBut.Click += new System.EventHandler(this.ReloadBut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 63);
            this.panel2.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.TaskInfo);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(225, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(470, 63);
            this.panel7.TabIndex = 1;
            // 
            // TaskInfo
            // 
            this.TaskInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskInfo.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskInfo.ForeColor = System.Drawing.Color.Aquamarine;
            this.TaskInfo.Location = new System.Drawing.Point(0, 0);
            this.TaskInfo.Name = "TaskInfo";
            this.TaskInfo.Size = new System.Drawing.Size(468, 61);
            this.TaskInfo.TabIndex = 1;
            this.TaskInfo.Text = "Задачи";
            this.TaskInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.DataInfo);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 63);
            this.panel8.TabIndex = 0;
            // 
            // DataInfo
            // 
            this.DataInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataInfo.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInfo.ForeColor = System.Drawing.Color.Aquamarine;
            this.DataInfo.Location = new System.Drawing.Point(0, 0);
            this.DataInfo.Name = "DataInfo";
            this.DataInfo.Size = new System.Drawing.Size(223, 61);
            this.DataInfo.TabIndex = 0;
            this.DataInfo.Text = "Дата";
            this.DataInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 556);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ToolPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormView";
            this.Text = "FormView";
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label TaskInfo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label DataInfo;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button ReloadBut;
        private System.Windows.Forms.Button NextBut;
        private System.Windows.Forms.TextBox CountLabel;
        private System.Windows.Forms.Button LastBut;
        private System.Windows.Forms.Button ReCount;
    }
}