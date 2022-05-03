namespace GestaoTarefas.WinApp
{
    partial class CadastroContatos
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
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGravarContato = new System.Windows.Forms.Button();
            this.txtContatoNome = new System.Windows.Forms.TextBox();
            this.txtContatnoEmail = new System.Windows.Forms.TextBox();
            this.txtContatoTel = new System.Windows.Forms.TextBox();
            this.txtContatoEmpresa = new System.Windows.Forms.TextBox();
            this.TxtContatoCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(26, 78);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(46, 15);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empresa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cargo :";
            // 
            // btnGravarContato
            // 
            this.btnGravarContato.Location = new System.Drawing.Point(201, 329);
            this.btnGravarContato.Name = "btnGravarContato";
            this.btnGravarContato.Size = new System.Drawing.Size(173, 51);
            this.btnGravarContato.TabIndex = 5;
            this.btnGravarContato.Text = "Gravar";
            this.btnGravarContato.UseVisualStyleBackColor = true;
            this.btnGravarContato.Click += new System.EventHandler(this.btnGravarContato_Click);
            // 
            // txtContatoNome
            // 
            this.txtContatoNome.Location = new System.Drawing.Point(90, 75);
            this.txtContatoNome.Name = "txtContatoNome";
            this.txtContatoNome.Size = new System.Drawing.Size(454, 23);
            this.txtContatoNome.TabIndex = 6;
            // 
            // txtContatnoEmail
            // 
            this.txtContatnoEmail.Location = new System.Drawing.Point(90, 110);
            this.txtContatnoEmail.Name = "txtContatnoEmail";
            this.txtContatnoEmail.Size = new System.Drawing.Size(454, 23);
            this.txtContatnoEmail.TabIndex = 7;
            // 
            // txtContatoTel
            // 
            this.txtContatoTel.Location = new System.Drawing.Point(90, 155);
            this.txtContatoTel.Name = "txtContatoTel";
            this.txtContatoTel.Size = new System.Drawing.Size(454, 23);
            this.txtContatoTel.TabIndex = 8;
            // 
            // txtContatoEmpresa
            // 
            this.txtContatoEmpresa.Location = new System.Drawing.Point(90, 199);
            this.txtContatoEmpresa.Name = "txtContatoEmpresa";
            this.txtContatoEmpresa.Size = new System.Drawing.Size(454, 23);
            this.txtContatoEmpresa.TabIndex = 9;
            // 
            // TxtContatoCargo
            // 
            this.TxtContatoCargo.Location = new System.Drawing.Point(90, 244);
            this.TxtContatoCargo.Name = "TxtContatoCargo";
            this.TxtContatoCargo.Size = new System.Drawing.Size(454, 23);
            this.TxtContatoCargo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de Contatos";
            // 
            // CadastroContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContatoCargo);
            this.Controls.Add(this.txtContatoEmpresa);
            this.Controls.Add(this.txtContatoTel);
            this.Controls.Add(this.txtContatnoEmail);
            this.Controls.Add(this.txtContatoNome);
            this.Controls.Add(this.btnGravarContato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Name = "CadastroContatos";
            this.Text = "CadastroContatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGravarContato;
        private System.Windows.Forms.TextBox txtContatoNome;
        private System.Windows.Forms.TextBox txtContatnoEmail;
        private System.Windows.Forms.TextBox txtContatoTel;
        private System.Windows.Forms.TextBox txtContatoEmpresa;
        private System.Windows.Forms.TextBox TxtContatoCargo;
        private System.Windows.Forms.Label label1;
    }
}