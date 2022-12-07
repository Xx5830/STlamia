
namespace STlamia1._1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewBut = new System.Windows.Forms.Button();
            this.AnalitickBut = new System.Windows.Forms.Button();
            this.CalendaryBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(171, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(695, 556);
            this.MainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::STlamia1._1.ImageFon.Panel_171x556;
            this.panel1.Controls.Add(this.ExitBut);
            this.panel1.Controls.Add(this.ViewBut);
            this.panel1.Controls.Add(this.AnalitickBut);
            this.panel1.Controls.Add(this.CalendaryBut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 556);
            this.panel1.TabIndex = 0;
            // 
            // ViewBut
            // 
            this.ViewBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewBut.FlatAppearance.BorderSize = 0;
            this.ViewBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewBut.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBut.Image = global::STlamia1._1.ImageFon.Panel3_171x43Old;
            this.ViewBut.Location = new System.Drawing.Point(0, 142);
            this.ViewBut.Name = "ViewBut";
            this.ViewBut.Size = new System.Drawing.Size(171, 43);
            this.ViewBut.TabIndex = 3;
            this.ViewBut.Text = "Обзор";
            this.ViewBut.UseVisualStyleBackColor = true;
            this.ViewBut.Click += new System.EventHandler(this.ViewBut_Click);
            // 
            // AnalitickBut
            // 
            this.AnalitickBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnalitickBut.FlatAppearance.BorderSize = 0;
            this.AnalitickBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnalitickBut.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalitickBut.Image = global::STlamia1._1.ImageFon.Panel3_171x43Old;
            this.AnalitickBut.Location = new System.Drawing.Point(0, 99);
            this.AnalitickBut.Name = "AnalitickBut";
            this.AnalitickBut.Size = new System.Drawing.Size(171, 43);
            this.AnalitickBut.TabIndex = 2;
            this.AnalitickBut.Text = "Статистика";
            this.AnalitickBut.UseVisualStyleBackColor = true;
            this.AnalitickBut.Click += new System.EventHandler(this.AnalitickBut_Click);
            // 
            // CalendaryBut
            // 
            this.CalendaryBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalendaryBut.FlatAppearance.BorderSize = 0;
            this.CalendaryBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalendaryBut.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendaryBut.Image = global::STlamia1._1.ImageFon.Panel3_171x43New;
            this.CalendaryBut.Location = new System.Drawing.Point(0, 56);
            this.CalendaryBut.Name = "CalendaryBut";
            this.CalendaryBut.Size = new System.Drawing.Size(171, 43);
            this.CalendaryBut.TabIndex = 1;
            this.CalendaryBut.Text = "Календарь";
            this.CalendaryBut.UseVisualStyleBackColor = true;
            this.CalendaryBut.Click += new System.EventHandler(this.CalendaryBut_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Image = global::STlamia1._1.ImageFon.Panel3_171x56;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acmp.ru";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitBut
            // 
            this.ExitBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitBut.FlatAppearance.BorderSize = 0;
            this.ExitBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBut.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBut.Image = global::STlamia1._1.ImageFon.Panel3_171x43Old;
            this.ExitBut.Location = new System.Drawing.Point(0, 185);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(171, 43);
            this.ExitBut.TabIndex = 4;
            this.ExitBut.Text = "Выход";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.BackgroundImage = global::STlamia1._1.ImageFon.Mainfon;
            this.ClientSize = new System.Drawing.Size(866, 556);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CalendaryBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewBut;
        private System.Windows.Forms.Button AnalitickBut;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ExitBut;
    }
}

