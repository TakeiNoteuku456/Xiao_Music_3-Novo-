namespace Xiao_Music_3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Voltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStopMarceline = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Voltar.BackgroundImage")));
            this.Voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Voltar.Location = new System.Drawing.Point(12, 12);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(66, 62);
            this.Voltar.TabIndex = 1;
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(125, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Em desenvolvimento";
            // 
            // buttonStopMarceline
            // 
            this.buttonStopMarceline.BackColor = System.Drawing.Color.Transparent;
            this.buttonStopMarceline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStopMarceline.BackgroundImage")));
            this.buttonStopMarceline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStopMarceline.ForeColor = System.Drawing.Color.Transparent;
            this.buttonStopMarceline.Location = new System.Drawing.Point(217, 193);
            this.buttonStopMarceline.Name = "buttonStopMarceline";
            this.buttonStopMarceline.Size = new System.Drawing.Size(44, 47);
            this.buttonStopMarceline.TabIndex = 6;
            this.buttonStopMarceline.UseVisualStyleBackColor = false;
            this.buttonStopMarceline.Click += new System.EventHandler(this.buttonStopMarceline_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Transparent;
            this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button27.ForeColor = System.Drawing.Color.Transparent;
            this.button27.Location = new System.Drawing.Point(167, 193);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(44, 47);
            this.button27.TabIndex = 80;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.buttonStopMarceline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Voltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStopMarceline;
        private System.Windows.Forms.Button button27;
    }
}