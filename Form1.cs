
namespace Desafio_4_Estacionamento
{
    public partial class Form1 : Form
    {
        private List<Veiculo> listaVeiculos = new();
        private List<Veiculo> listaSaida = new();

        public Form1()
        {
            InitializeComponent();

            Persistencia.LerArquivoEntrada(listaVeiculos);

            //populando listbox
            foreach (var item in listaVeiculos)
            {
                listBoxVeiculosGaragem.Items.Add($"{item.Placa}; {item.DataEntrada:d}; {item.HoraEntrada:t}");
            }

            Persistencia.LerArquivosSaida(listaSaida);

            //populando listbox
            foreach (var item in listaSaida)
            {
                listBoxVeiculosSaida.Items.Add($"{item.Placa};{item.DataEntrada:d};{item.HoraEntrada:t};{item.TempoPermanencia:hh\\:mm\\:ss};{item.ValorCobrado}");
            }
        }

        private void EntradaCarro(object sender, EventArgs e)
        {
            DateTime dataEntrada = DateTime.Today;
            DateTime horaEntrada = DateTime.Now;
            string placa = textBoxPlacaCarro.Text;

            Veiculo veiculo = new(placa, dataEntrada, horaEntrada);

            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("Insira a placa do carro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Veiculo.EstacionamentoAberto(horaEntrada))
            {
                MessageBox.Show("O Estacionamento está fora do horário de funcionamento. Volte mais tarde.");
                return;
            }

            if (!Veiculo.TemLugar(listaVeiculos))
            {
                MessageBox.Show("Garagem atingiu a capacidade máxima (50)");
                return;
            }

            if (Veiculo.JaCadastrado(veiculo.Placa, listaVeiculos))
            {
                MessageBox.Show("Veículo ja cadastrado!!!!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            listaVeiculos.Add(veiculo);
            listBoxVeiculosGaragem.Items.Add($"{veiculo.Placa}; {veiculo.DataEntrada:d}; {veiculo.HoraEntrada:t}");

            Persistencia.GravarArquivoEntrada(veiculo);
        }

        private void SaidaCarro(object sender, EventArgs e)
        {
            string input = textBoxPlacaCarro.Text;
            Veiculo veiculo = Veiculo.EncontrarVeiculo(input, listaVeiculos);

            if (!Veiculo.JaCadastrado(input, listaVeiculos))
            {
                MessageBox.Show("Veículo não cadastrado no sistema!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Veiculo.EstacionamentoAberto(DateTime.Now))
            {
                MessageBox.Show("O Estacionamento está fora do horário de funcionamento. Volte mais tarde.");
                return;
            }

            veiculo.TempoPermanencia = DateTime.Now.Subtract(veiculo.HoraEntrada);
            veiculo.ValorCobrado = Math.Ceiling(veiculo.TempoPermanencia.TotalHours) * 5;


            listBoxVeiculosSaida.Items.Add($"{veiculo.Placa};{veiculo.DataEntrada:d};{veiculo.HoraEntrada:t};{veiculo.TempoPermanencia:hh\\:mm\\:ss};{veiculo.ValorCobrado} {Environment.NewLine}");
            listaSaida.Add(veiculo);
            listaVeiculos.Remove(veiculo);
            labelTempoPermanencia.Text = veiculo.TempoPermanencia.ToString(@"hh\:mm\:ss");
            label2.Text = $"R${veiculo.ValorCobrado},00";


            //removendo da listbox
            for (int i = listBoxVeiculosGaragem.Items.Count - 1; i >= 0; i--)
            {
                string item = listBoxVeiculosGaragem.Items[i].ToString();

                if (item.Contains(veiculo.Placa))
                {
                    listBoxVeiculosGaragem.Items.RemoveAt(i);
                }
            }

            MessageBox.Show($"Placa: {veiculo.Placa} Tempo de permanência: {veiculo.TempoPermanencia:hh\\:mm\\:ss} Valor a pagar: R${veiculo.ValorCobrado},00", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Persistencia.GravarArquivoVeiculosSaida(veiculo);
            Persistencia.AtualizarArquivoEntrada(listaVeiculos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelHoraAtual.Text = DateTime.Now.ToString("g");
        }
    }
}