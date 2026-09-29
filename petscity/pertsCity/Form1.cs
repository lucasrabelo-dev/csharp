namespace pertsCity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                petsCity negocio = new petsCity();

                negocio.NomePet = txtNomePet.Text;
                negocio.PrecoUnitario = Convert.ToDouble(txtPreçoUnitario.Text);
                negocio.QuantidadesBanho = int.Parse(txtQuantidadeBanho.Text);
                negocio.IdadeAnimal = int.Parse(txtIdadePet.Text);

                double desconto = negocio.calcularDesconto();
                double valorFinal = negocio.CalcularValorFinal();
                double parcela = negocio.Calcularparcela();
                bool brindeAprovado = negocio.ValidaBrinde();

                lblNome.Text = $"{negocio.NomePet.ToUpper()}";
                lblDesconto.Text = $"Desconto: R${desconto:N2}";
                lblValorFinal.Text = $"Valor final: R${valorFinal:N2}";
                lblParcela.Text = $"Pode parcelar em até 3x de R${parcela:N2}";


                txtNomePet.Clear();
                txtPreçoUnitario.Clear();
                txtQuantidadeBanho.Clear();
                txtIdadePet.Clear();

                if (brindeAprovado)
                {
                    lblStatus.Text = "PARABÉNS! Você ganhou um Brinde";
                    lblStatus.ForeColor = Color.Green;

                }

                else
                {
                    lblStatus.Text = "Compra padrão realizada com sucesso!";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            catch (FormatException) //Se acontecer um erro especificamente de formato inválido dentro do bloco try,
                                    //capture esse erro aqui e execute este código de segurança."
            {


                MessageBox.Show("Preencha os campos numéricos corretamente!",
                    "Erro de digitação", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }

        }

        private void txtNomePet_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDesconto_Click(object sender, EventArgs e)
        {

        }
    }
}
