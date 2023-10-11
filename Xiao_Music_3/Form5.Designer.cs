namespace Xiao_Music_3
{
    partial class Youtube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Youtube));
            this.Volta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Volta
            // 
            this.Volta.Location = new System.Drawing.Point(1823, 1);
            this.Volta.Name = "Volta";
            this.Volta.Size = new System.Drawing.Size(81, 57);
            this.Volta.TabIndex = 0;
            this.Volta.Text = "Volta";
            this.Volta.UseVisualStyleBackColor = true;
            this.Volta.Click += new System.EventHandler(this.Volta_Click);
            // 
            // Youtube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Volta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Youtube";
            this.Text = "Youtube";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volta;
    }
}