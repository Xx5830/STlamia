
namespace STlamia1._1
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.NonLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.MaskedTextBox();
            this.MonthBox = new System.Windows.Forms.MaskedTextBox();
            this.DayBox = new System.Windows.Forms.MaskedTextBox();
            this.TaskBox = new System.Windows.Forms.MaskedTextBox();
            this.TimeBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DifficultBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ReferenseBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Задача";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Add.Location = new System.Drawing.Point(253, 243);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 35);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добававить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Cancel.Location = new System.Drawing.Point(12, 243);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 35);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NonLabel
            // 
            this.NonLabel.AutoSize = true;
            this.NonLabel.BackColor = System.Drawing.Color.Transparent;
            this.NonLabel.ForeColor = System.Drawing.Color.Red;
            this.NonLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NonLabel.Location = new System.Drawing.Point(219, 0);
            this.NonLabel.Name = "NonLabel";
            this.NonLabel.Size = new System.Drawing.Size(132, 13);
            this.NonLabel.TabIndex = 6;
            this.NonLabel.Text = "*Не правильный формат";
            this.NonLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Время";
            // 
            // YearBox
            // 
            this.YearBox.BackColor = System.Drawing.Color.MediumPurple;
            this.YearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YearBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearBox.ForeColor = System.Drawing.Color.Maroon;
            this.YearBox.Location = new System.Drawing.Point(140, 15);
            this.YearBox.Mask = "0000";
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(52, 25);
            this.YearBox.TabIndex = 1;
            this.YearBox.Text = "2022";
            this.YearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YearBox.ValidatingType = typeof(System.DateTime);
            // 
            // MonthBox
            // 
            this.MonthBox.BackColor = System.Drawing.Color.MediumPurple;
            this.MonthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MonthBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthBox.ForeColor = System.Drawing.Color.Maroon;
            this.MonthBox.Location = new System.Drawing.Point(200, 15);
            this.MonthBox.Mask = "00";
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(48, 25);
            this.MonthBox.TabIndex = 1;
            this.MonthBox.Text = "12";
            this.MonthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DayBox
            // 
            this.DayBox.BackColor = System.Drawing.Color.MediumPurple;
            this.DayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DayBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayBox.ForeColor = System.Drawing.Color.Maroon;
            this.DayBox.Location = new System.Drawing.Point(253, 15);
            this.DayBox.Mask = "00";
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(48, 25);
            this.DayBox.TabIndex = 1;
            this.DayBox.Text = "04";
            this.DayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DayBox.ValidatingType = typeof(System.DateTime);
            // 
            // TaskBox
            // 
            this.TaskBox.BackColor = System.Drawing.Color.MediumPurple;
            this.TaskBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskBox.ForeColor = System.Drawing.Color.Maroon;
            this.TaskBox.Location = new System.Drawing.Point(141, 106);
            this.TaskBox.Mask = "000";
            this.TaskBox.Name = "TaskBox";
            this.TaskBox.Size = new System.Drawing.Size(131, 25);
            this.TaskBox.TabIndex = 1;
            this.TaskBox.Text = "100";
            this.TaskBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TaskBox.ValidatingType = typeof(System.DateTime);
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.Color.MediumPurple;
            this.TimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBox.ForeColor = System.Drawing.Color.Maroon;
            this.TimeBox.Location = new System.Drawing.Point(141, 59);
            this.TimeBox.Mask = "00:00";
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(131, 25);
            this.TimeBox.TabIndex = 1;
            this.TimeBox.Text = "1200";
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumPurple;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(192, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumPurple;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(239, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "/";
            // 
            // DifficultBox
            // 
            this.DifficultBox.BackColor = System.Drawing.Color.MediumPurple;
            this.DifficultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DifficultBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultBox.ForeColor = System.Drawing.Color.Maroon;
            this.DifficultBox.Location = new System.Drawing.Point(141, 151);
            this.DifficultBox.Mask = "00";
            this.DifficultBox.Name = "DifficultBox";
            this.DifficultBox.Size = new System.Drawing.Size(131, 25);
            this.DifficultBox.TabIndex = 1;
            this.DifficultBox.Text = "10";
            this.DifficultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DifficultBox.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(7, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Сложность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(24, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ссылка";
            // 
            // ReferenseBox
            // 
            this.ReferenseBox.BackColor = System.Drawing.Color.MediumPurple;
            this.ReferenseBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReferenseBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenseBox.ForeColor = System.Drawing.Color.Maroon;
            this.ReferenseBox.Location = new System.Drawing.Point(141, 197);
            this.ReferenseBox.Name = "ReferenseBox";
            this.ReferenseBox.Size = new System.Drawing.Size(160, 19);
            this.ReferenseBox.TabIndex = 8;
            this.ReferenseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReferenseBox.WordWrap = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::STlamia1._1.ImageFon.Add_Fon5;
            this.ClientSize = new System.Drawing.Size(360, 290);
            this.Controls.Add(this.ReferenseBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NonLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DifficultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label NonLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox YearBox;
        private System.Windows.Forms.MaskedTextBox MonthBox;
        private System.Windows.Forms.MaskedTextBox DayBox;
        private System.Windows.Forms.MaskedTextBox TaskBox;
        private System.Windows.Forms.MaskedTextBox TimeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox DifficultBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ReferenseBox;
    }
}