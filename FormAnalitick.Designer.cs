
namespace STlamia1._1
{
    partial class FormAnalitick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnalitick));
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(24, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(165, 47);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Analitick";
            // 
            // FormAnalitick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 556);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnalitick";
            this.Text = "FormAnalitick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
    }
}