namespace InfosCEP
{
    partial class ConsultorDeCEP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultorDeCEP));
            this.CEP = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doideira = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeDaRua = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LogradouroTextBox = new System.Windows.Forms.TextBox();
            this.BairroTextBox = new System.Windows.Forms.TextBox();
            this.LocalidadeTextBox = new System.Windows.Forms.TextBox();
            this.UFTextBox = new System.Windows.Forms.TextBox();
            this.BtnPesquisarCep = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // CEP
            // 
            this.CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CEP.Location = new System.Drawing.Point(231, 59);
            this.CEP.Multiline = true;
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(180, 35);
            this.CEP.TabIndex = 0;
            this.CEP.TextChanged += new System.EventHandler(this.CEP_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // doideira
            // 
            this.doideira.AutoSize = true;
            this.doideira.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doideira.Location = new System.Drawing.Point(26, 62);
            this.doideira.Name = "doideira";
            this.doideira.Size = new System.Drawing.Size(190, 32);
            this.doideira.TabIndex = 3;
            this.doideira.Text = "Digite seu CEP: ";
            this.doideira.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cidade: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bairro: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomeDaRua
            // 
            this.NomeDaRua.AutoSize = true;
            this.NomeDaRua.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeDaRua.Location = new System.Drawing.Point(19, 141);
            this.NomeDaRua.Name = "NomeDaRua";
            this.NomeDaRua.Size = new System.Drawing.Size(180, 32);
            this.NomeDaRua.TabIndex = 6;
            this.NomeDaRua.Text = "Nome Da Rua: ";
            this.NomeDaRua.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado: ";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // LogradouroTextBox
            // 
            this.LogradouroTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogradouroTextBox.Location = new System.Drawing.Point(208, 138);
            this.LogradouroTextBox.Multiline = true;
            this.LogradouroTextBox.Name = "LogradouroTextBox";
            this.LogradouroTextBox.Size = new System.Drawing.Size(359, 35);
            this.LogradouroTextBox.TabIndex = 8;
            this.LogradouroTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BairroTextBox
            // 
            this.BairroTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BairroTextBox.Location = new System.Drawing.Point(208, 193);
            this.BairroTextBox.Multiline = true;
            this.BairroTextBox.Name = "BairroTextBox";
            this.BairroTextBox.Size = new System.Drawing.Size(359, 35);
            this.BairroTextBox.TabIndex = 9;
            this.BairroTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LocalidadeTextBox
            // 
            this.LocalidadeTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalidadeTextBox.Location = new System.Drawing.Point(208, 244);
            this.LocalidadeTextBox.Multiline = true;
            this.LocalidadeTextBox.Name = "LocalidadeTextBox";
            this.LocalidadeTextBox.Size = new System.Drawing.Size(359, 35);
            this.LocalidadeTextBox.TabIndex = 10;
            this.LocalidadeTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // UFTextBox
            // 
            this.UFTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UFTextBox.Location = new System.Drawing.Point(208, 297);
            this.UFTextBox.Multiline = true;
            this.UFTextBox.Name = "UFTextBox";
            this.UFTextBox.Size = new System.Drawing.Size(359, 35);
            this.UFTextBox.TabIndex = 11;
            this.UFTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // BtnPesquisarCep
            // 
            this.BtnPesquisarCep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPesquisarCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnPesquisarCep.Location = new System.Drawing.Point(456, 59);
            this.BtnPesquisarCep.Name = "BtnPesquisarCep";
            this.BtnPesquisarCep.Size = new System.Drawing.Size(111, 34);
            this.BtnPesquisarCep.TabIndex = 12;
            this.BtnPesquisarCep.Text = "Pesquisar";
            this.BtnPesquisarCep.UseVisualStyleBackColor = false;
            this.BtnPesquisarCep.Click += new System.EventHandler(this.BtnPesquisarCep_ClickAsync);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip3.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip3_Opening);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip4.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip4_Opening);
            // 
            // ConsultorDeCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.BtnPesquisarCep);
            this.Controls.Add(this.UFTextBox);
            this.Controls.Add(this.LocalidadeTextBox);
            this.Controls.Add(this.BairroTextBox);
            this.Controls.Add(this.LogradouroTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomeDaRua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doideira);
            this.Controls.Add(this.CEP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultorDeCEP";
            this.Text = "Consultor De CEP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CEP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label doideira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NomeDaRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LogradouroTextBox;
        private System.Windows.Forms.TextBox BairroTextBox;
        private System.Windows.Forms.TextBox LocalidadeTextBox;
        private System.Windows.Forms.TextBox UFTextBox;
        private System.Windows.Forms.Button BtnPesquisarCep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
    }
}

