namespace pertsCity
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
            lblNomePet = new Label();
            lblQuantidadeBanho = new Label();
            lblPreçoUnitario = new Label();
            lblIdadeAnimal = new Label();
            txtNomePet = new TextBox();
            txtPreçoUnitario = new TextBox();
            txtQuantidadeBanho = new TextBox();
            txtIdadePet = new TextBox();
            lblNome = new Label();
            lblDesconto = new Label();
            lblValorFinal = new Label();
            lblParcela = new Label();
            lblStatus = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Location = new Point(12, 24);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(60, 15);
            lblNomePet.TabIndex = 0;
            lblNomePet.Text = "Nome Pet";
            // 
            // lblQuantidadeBanho
            // 
            lblQuantidadeBanho.AutoSize = true;
            lblQuantidadeBanho.Location = new Point(12, 111);
            lblQuantidadeBanho.Name = "lblQuantidadeBanho";
            lblQuantidadeBanho.Size = new Size(106, 15);
            lblQuantidadeBanho.TabIndex = 1;
            lblQuantidadeBanho.Text = "Quantidade Banho";
            // 
            // lblPreçoUnitario
            // 
            lblPreçoUnitario.AutoSize = true;
            lblPreçoUnitario.Location = new Point(12, 63);
            lblPreçoUnitario.Name = "lblPreçoUnitario";
            lblPreçoUnitario.Size = new Size(82, 15);
            lblPreçoUnitario.TabIndex = 2;
            lblPreçoUnitario.Text = "Preço Unitario";
            // 
            // lblIdadeAnimal
            // 
            lblIdadeAnimal.AutoSize = true;
            lblIdadeAnimal.Location = new Point(12, 161);
            lblIdadeAnimal.Name = "lblIdadeAnimal";
            lblIdadeAnimal.Size = new Size(77, 15);
            lblIdadeAnimal.TabIndex = 3;
            lblIdadeAnimal.Text = "Idade Animal";
            // 
            // txtNomePet
            // 
            txtNomePet.Location = new Point(129, 16);
            txtNomePet.Name = "txtNomePet";
            txtNomePet.Size = new Size(100, 23);
            txtNomePet.TabIndex = 4;
            txtNomePet.TextChanged += txtNomePet_TextChanged;
            // 
            // txtPreçoUnitario
            // 
            txtPreçoUnitario.Location = new Point(129, 63);
            txtPreçoUnitario.Name = "txtPreçoUnitario";
            txtPreçoUnitario.Size = new Size(100, 23);
            txtPreçoUnitario.TabIndex = 5;
            // 
            // txtQuantidadeBanho
            // 
            txtQuantidadeBanho.Location = new Point(129, 111);
            txtQuantidadeBanho.Name = "txtQuantidadeBanho";
            txtQuantidadeBanho.Size = new Size(100, 23);
            txtQuantidadeBanho.TabIndex = 6;
            // 
            // txtIdadePet
            // 
            txtIdadePet.Location = new Point(129, 161);
            txtIdadePet.Name = "txtIdadePet";
            txtIdadePet.Size = new Size(100, 23);
            txtIdadePet.TabIndex = 7;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(50, 213);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(49, 242);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 9;
            lblDesconto.Text = "Desconto";
            lblDesconto.Click += lblDesconto_Click;
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(49, 272);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(58, 15);
            lblValorFinal.TabIndex = 10;
            lblValorFinal.Text = "ValorFinal";
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(50, 302);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(45, 15);
            lblParcela.TabIndex = 11;
            lblParcela.Text = "Parcela";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(50, 332);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(328, 398);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblStatus);
            Controls.Add(lblParcela);
            Controls.Add(lblValorFinal);
            Controls.Add(lblDesconto);
            Controls.Add(lblNome);
            Controls.Add(txtIdadePet);
            Controls.Add(txtQuantidadeBanho);
            Controls.Add(txtPreçoUnitario);
            Controls.Add(txtNomePet);
            Controls.Add(lblIdadeAnimal);
            Controls.Add(lblPreçoUnitario);
            Controls.Add(lblQuantidadeBanho);
            Controls.Add(lblNomePet);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomePet;
        private Label lblQuantidadeBanho;
        private Label lblPreçoUnitario;
        private Label lblIdadeAnimal;
        private TextBox txtNomePet;
        private TextBox txtPreçoUnitario;
        private TextBox txtQuantidadeBanho;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtIdadePet;
        private Label lblNome;
        private Label lblDesconto;
        private Label lblValorFinal;
        private Label lblParcela;
        private Label lblStatus;
        private Button btnCalcular;
    }
}
