namespace Pmatrizes
{
    partial class Exercicio5
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblRespostas = new System.Windows.Forms.Label();
            this.lstRespostas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(74, 263);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(132, 47);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(74, 358);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(132, 45);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblRespostas
            // 
            this.lblRespostas.AutoSize = true;
            this.lblRespostas.Location = new System.Drawing.Point(288, 67);
            this.lblRespostas.Name = "lblRespostas";
            this.lblRespostas.Size = new System.Drawing.Size(86, 20);
            this.lblRespostas.TabIndex = 2;
            this.lblRespostas.Text = "Respostas";
            // 
            // lstRespostas
            // 
            this.lstRespostas.FormattingEnabled = true;
            this.lstRespostas.ItemHeight = 20;
            this.lstRespostas.Location = new System.Drawing.Point(292, 90);
            this.lstRespostas.Name = "lstRespostas";
            this.lstRespostas.Size = new System.Drawing.Size(401, 324);
            this.lstRespostas.TabIndex = 3;
            // 
            // Exercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 434);
            this.Controls.Add(this.lstRespostas);
            this.Controls.Add(this.lblRespostas);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVerificar);
            this.Name = "Exercicio5";
            this.Text = "Exercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblRespostas;
        private System.Windows.Forms.ListBox lstRespostas;
    }
}