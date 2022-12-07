
namespace STlamia1._1
{
    partial class USBlank
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.Color.Transparent;
            this.Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Number.Location = new System.Drawing.Point(0, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(93, 40);
            this.Number.TabIndex = 0;
            this.Number.Text = "Non";
            this.Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number.Click += new System.EventHandler(this.Number_Click);
            // 
            // USBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Number);
            this.Name = "USBlank";
            this.Size = new System.Drawing.Size(93, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Number;
    }
}
