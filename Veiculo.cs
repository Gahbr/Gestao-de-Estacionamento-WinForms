//Para o Classe Veiculo:
//atributos: placaVeiculo, dataEntrada, horaEntrada, tempoPermanencia, valorCobrado
//métodos: construtor só com placaVeiculo, dataEntrada, horaEntrada; getters e setters

namespace Desafio_4_Estacionamento
{
    internal class Veiculo
    {
        public string Placa { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime HoraEntrada { get; set; }
        public TimeSpan TempoPermanencia { get; set; }
        public double ValorCobrado { get; set; }

        public Veiculo(string placa, DateTime dataEntrada, DateTime horaEntrada)
        {
            Placa = placa;
            DataEntrada = dataEntrada;
            HoraEntrada = horaEntrada;
        }

        public Veiculo(string placa, DateTime dataEntrada, DateTime horaEntrada, TimeSpan tempoPermanencia, double valorCobrado) : this(placa, dataEntrada, horaEntrada)
        {
            TempoPermanencia = tempoPermanencia;
            ValorCobrado = valorCobrado;
        }

        public static bool JaCadastrado(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo v in lista)
            {
                if (placa.Equals(v.Placa)) return true;
                
            }
            return false; // veículo nao encontrado na lista
        }

        public static Veiculo EncontrarVeiculo(string placa, List<Veiculo> listaVeiculos)
        {
            Veiculo veiculoEncontrado;

            foreach (Veiculo veiculo in listaVeiculos)
            {
                if (veiculo.Placa == placa)
                {
                    veiculoEncontrado = veiculo;
                    return veiculoEncontrado;
                }
            }
            return null;
        }

        public static bool TemLugar(List<Veiculo> lista)
        {
            if (lista.Count >= 50) return false;
            return true;
        }

        public static bool EstacionamentoAberto(DateTime hour)
        {
            if (hour.Hour < 7 && hour.Hour > 20) return false;
            return true;
        }

        public override bool Equals(object? obj)
        {
            return obj is Veiculo veiculo &&
                   Placa == veiculo.Placa &&
                   DataEntrada == veiculo.DataEntrada &&
                   HoraEntrada == veiculo.HoraEntrada &&
                   TempoPermanencia.Equals(veiculo.TempoPermanencia) &&
                   ValorCobrado == veiculo.ValorCobrado;
        }
    }
}
