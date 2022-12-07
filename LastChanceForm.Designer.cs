
namespace STlamia1._1
{
    partial class LastChanceForm
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
            this.LabelInfo = new System.Windows.Forms.Label();
            this.YesBut = new System.Windows.Forms.Button();
            this.NoBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelInfo
            // 
            this.LabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfo.Location = new System.Drawing.Point(7, -1);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(174, 74);
            this.LabelInfo.TabIndex = 0;
            this.LabelInfo.Text = "Вы правда хотите выполнить данную операцию? Отменить ее нельзя";
            this.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YesBut
            // 
            this.YesBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YesBut.Location = new System.Drawing.Point(8, 76);
            this.YesBut.Name = "YesBut";
            this.YesBut.Size = new System.Drawing.Size(75, 23);
            this.YesBut.TabIndex = 1;
            this.YesBut.Text = "Да";
            this.YesBut.UseVisualStyleBackColor = true;
            this.YesBut.Click += new System.EventHandler(this.YesBut_Click);
            // 
            // NoBut
            // 
            this.NoBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NoBut.Location = new System.Drawing.Point(106, 76);
            this.NoBut.Name = "NoBut";
            this.NoBut.Size = new System.Drawing.Size(75, 23);
            this.NoBut.TabIndex = 1;
            this.NoBut.Text = "Нет";
            this.NoBut.UseVisualStyleBackColor = true;
            this.NoBut.Click += new System.EventHandler(this.NoBut_Click);
            // 
            // LastChanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(189, 108);
            this.Controls.Add(this.NoBut);
            this.Controls.Add(this.YesBut);
            this.Controls.Add(this.LabelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LastChanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastChanceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Button YesBut;
        private System.Windows.Forms.Button NoBut;
    }
}