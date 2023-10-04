namespace Xiao_Music_3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textnome = new System.Windows.Forms.TextBox();
            this.labelsenha = new System.Windows.Forms.Label();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colunaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunanome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunasenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(83, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME:";
            // 
            // textnome
            // 
            this.textnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnome.Location = new System.Drawing.Point(92, 151);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(515, 62);
            this.textnome.TabIndex = 4;
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.BackColor = System.Drawing.Color.Transparent;
            this.labelsenha.Font = new System.Drawing.Font("BankGothic Md BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsenha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelsenha.Location = new System.Drawing.Point(83, 259);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(234, 50);
            this.labelsenha.TabIndex = 5;
            this.labelsenha.Text = "SENHA:";
            // 
            // textsenha
            // 
            this.textsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsenha.Location = new System.Drawing.Point(92, 312);
            this.textsenha.Name = "textsenha";
            this.textsenha.PasswordChar = '*';
            this.textsenha.Size = new System.Drawing.Size(515, 62);
            this.textsenha.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(92, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 85);
            this.button2.TabIndex = 7;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Location = new System.Drawing.Point(388, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 85);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cadastar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(512, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 85);
            this.button4.TabIndex = 9;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(1525, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 314);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaid,
            this.colunanome,
            this.colunasenha});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(92, 600);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 200);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_LR_MouseDoubleClick);
            // 
            // colunaid
            // 
            this.colunaid.Text = "ID";
            // 
            // colunanome
            // 
            this.colunanome.Text = "Nome";
            // 
            // colunasenha
            // 
            this.colunasenha.Text = "Senha";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.Location = new System.Drawing.Point(388, 504);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 79);
            this.button5.TabIndex = 12;
            this.button5.Text = "deletar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.labelsenha);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.Label labelsenha;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colunaid;
        private System.Windows.Forms.ColumnHeader colunanome;
        private System.Windows.Forms.ColumnHeader colunasenha;
        private System.Windows.Forms.Button button5;
    }
}

