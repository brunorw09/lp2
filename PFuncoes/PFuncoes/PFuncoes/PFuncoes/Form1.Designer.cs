namespace PFuncoes
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
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSoma1 = new System.Windows.Forms.Button();
            this.btnSoma2 = new System.Windows.Forms.Button();
            this.btnSoma3 = new System.Windows.Forms.Button();
            this.btnSoma4 = new System.Windows.Forms.Button();
            this.btnSoma5 = new System.Windows.Forms.Button();
            this.btnFormatacao1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(237, 161);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 43);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSoma1
            // 
            this.btnSoma1.Location = new System.Drawing.Point(379, 161);
            this.btnSoma1.Name = "btnSoma1";
            this.btnSoma1.Size = new System.Drawing.Size(75, 43);
            this.btnSoma1.TabIndex = 1;
            this.btnSoma1.Text = "Soma1";
            this.btnSoma1.UseVisualStyleBackColor = true;
            this.btnSoma1.Click += new System.EventHandler(this.btnSoma1_Click);
            // 
            // btnSoma2
            // 
            this.btnSoma2.Location = new System.Drawing.Point(495, 161);
            this.btnSoma2.Name = "btnSoma2";
            this.btnSoma2.Size = new System.Drawing.Size(75, 43);
            this.btnSoma2.TabIndex = 2;
            this.btnSoma2.Text = "Soma2";
            this.btnSoma2.UseVisualStyleBackColor = true;
            this.btnSoma2.Click += new System.EventHandler(this.btnSoma2_Click);
            // 
            // btnSoma3
            // 
            this.btnSoma3.Location = new System.Drawing.Point(634, 161);
            this.btnSoma3.Name = "btnSoma3";
            this.btnSoma3.Size = new System.Drawing.Size(75, 43);
            this.btnSoma3.TabIndex = 3;
            this.btnSoma3.Text = "Soma3";
            this.btnSoma3.UseVisualStyleBackColor = true;
            this.btnSoma3.Click += new System.EventHandler(this.btnSoma3_Click);
            // 
            // btnSoma4
            // 
            this.btnSoma4.Location = new System.Drawing.Point(770, 161);
            this.btnSoma4.Name = "btnSoma4";
            this.btnSoma4.Size = new System.Drawing.Size(75, 43);
            this.btnSoma4.TabIndex = 4;
            this.btnSoma4.Text = "Soma4";
            this.btnSoma4.UseVisualStyleBackColor = true;
            this.btnSoma4.Click += new System.EventHandler(this.btnSoma4_Click);
            // 
            // btnSoma5
            // 
            this.btnSoma5.Location = new System.Drawing.Point(902, 161);
            this.btnSoma5.Name = "btnSoma5";
            this.btnSoma5.Size = new System.Drawing.Size(75, 43);
            this.btnSoma5.TabIndex = 5;
            this.btnSoma5.Text = "Soma5";
            this.btnSoma5.UseVisualStyleBackColor = true;
            this.btnSoma5.Click += new System.EventHandler(this.btnSoma5_Click);
            // 
            // btnFormatacao1
            // 
            this.btnFormatacao1.Location = new System.Drawing.Point(143, 292);
            this.btnFormatacao1.Name = "btnFormatacao1";
            this.btnFormatacao1.Size = new System.Drawing.Size(190, 52);
            this.btnFormatacao1.TabIndex = 6;
            this.btnFormatacao1.Text = "Formatacao de Datas";
            this.btnFormatacao1.UseVisualStyleBackColor = true;
            this.btnFormatacao1.Click += new System.EventHandler(this.btnFormatacao1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 637);
            this.Controls.Add(this.btnFormatacao1);
            this.Controls.Add(this.btnSoma5);
            this.Controls.Add(this.btnSoma4);
            this.Controls.Add(this.btnSoma3);
            this.Controls.Add(this.btnSoma2);
            this.Controls.Add(this.btnSoma1);
            this.Controls.Add(this.btnSoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSoma1;
        private System.Windows.Forms.Button btnSoma2;
        private System.Windows.Forms.Button btnSoma3;
        private System.Windows.Forms.Button btnSoma4;
        private System.Windows.Forms.Button btnSoma5;
        private System.Windows.Forms.Button btnFormatacao1;
    }
}

