
namespace STlamia1._1
{
    partial class USCell
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
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.DataLabel = new System.Windows.Forms.Label();
            this.TaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskPanel
            // 
            this.TaskPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskPanel.Controls.Add(this.TaskLabel);
            this.TaskPanel.Controls.Add(this.DeleteBut);
            this.TaskPanel.Controls.Add(this.DataLabel);
            this.TaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(695, 49);
            this.TaskPanel.TabIndex = 0;
            // 
            // TaskLabel
            // 
            this.TaskLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskLabel.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskLabel.ForeColor = System.Drawing.Color.Black;
            this.TaskLabel.Location = new System.Drawing.Point(223, 0);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(384, 47);
            this.TaskLabel.TabIndex = 5;
            this.TaskLabel.Text = "364";
            this.TaskLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DeleteBut
            // 
            this.DeleteBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBut.ForeColor = System.Drawing.Color.Red;
            this.DeleteBut.Location = new System.Drawing.Point(607, 0);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(86, 47);
            this.DeleteBut.TabIndex = 3;
            this.DeleteBut.Text = "X";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // DataLabel
            // 
            this.DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataLabel.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataLabel.Location = new System.Drawing.Point(0, 0);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(223, 47);
            this.DataLabel.TabIndex = 4;
            this.DataLabel.Text = "2022.05.11 23:55";
            this.DataLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // USCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskPanel);
            this.Name = "USCell";
            this.Size = new System.Drawing.Size(695, 49);
            this.TaskPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Label DataLabel;
    }
}
