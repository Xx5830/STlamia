
namespace STlamia1._1
{
    partial class USInfo
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
            this.TaskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskLabel
            // 
            this.TaskLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.TaskLabel.Location = new System.Drawing.Point(0, 0);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(76, 59);
            this.TaskLabel.TabIndex = 0;
            this.TaskLabel.Text = "132";
            this.TaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TaskLabel.Click += new System.EventHandler(this.TaskLabel_Click);
            // 
            // USInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskLabel);
            this.Name = "USInfo";
            this.Size = new System.Drawing.Size(76, 59);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TaskLabel;
    }
}
