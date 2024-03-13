namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textCidade = new TextBox();
            label6 = new Label();
            txtCEP = new TextBox();
            label5 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtSobrenome = new TextBox();
            label3 = new Label();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnImprimir = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textCidade);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCEP);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSobrenome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe MDL2 Assets", 12F);
            groupBox1.Location = new Point(16, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(772, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Usuário:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textCidade
            // 
            textCidade.Location = new Point(292, 173);
            textCidade.Name = "textCidade";
            textCidade.Size = new Size(227, 23);
            textCidade.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 155);
            label6.Name = "label6";
            label6.Size = new Size(49, 16);
            label6.TabIndex = 10;
            label6.Text = "Cidade:";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(23, 173);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(227, 23);
            txtCEP.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 155);
            label5.Name = "label5";
            label5.Size = new Size(34, 16);
            label5.TabIndex = 8;
            label5.Text = "CEP:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(293, 112);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(227, 23);
            txtBairro.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 94);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 6;
            label4.Text = "Bairro:";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(292, 53);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(227, 23);
            txtSobrenome.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 35);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 4;
            label3.Text = "Sobrenome:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(24, 112);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(227, 23);
            txtEndereco.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 94);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 2;
            label2.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(23, 53);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(227, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(44, 16);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnImprimir);
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(btnSalvar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnNovo);
            groupBox2.Font = new Font("Segoe MDL2 Assets", 12F);
            groupBox2.Location = new Point(16, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(772, 101);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ações:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(338, 43);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 39);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(257, 43);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 39);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(176, 43);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 39);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(94, 43);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 39);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(13, 43);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 39);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textCidade;
        private Label label6;
        private TextBox txtCEP;
        private Label label5;
        private TextBox txtBairro;
        private Label label4;
        private TextBox txtSobrenome;
        private Label label3;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button btnImprimir;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
    }
}
