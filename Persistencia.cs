using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_4_Estacionamento
{
    internal class Persistencia
    {
        readonly static string entradaFilePath = "veiculosEntrada.dat";
        readonly static string saidaFilePath = "veiculosSaida.dat";

        public static void LerArquivoEntrada(List<Veiculo> listaVeiculos )
        {
            if (File.Exists(entradaFilePath) && new FileInfo(entradaFilePath).Length > 0)
            {
                StreamReader leitor = new(entradaFilePath);
                do
                {
                    string linha = leitor.ReadLine();
                    string[] vetorDados = linha.Split(";");
                    Veiculo veiculo = new(vetorDados[0], DateTime.Parse(vetorDados[1]), DateTime.Parse(vetorDados[2]));

                    listaVeiculos.Add(veiculo);

                } while (!leitor.EndOfStream);

                leitor.Close();
               
            }else
            {
                StreamWriter escritor = new(entradaFilePath);
                escritor.Close();
            }
        }

       public static void LerArquivosSaida(List<Veiculo> listaVeiculosSaida)
        {
            if (File.Exists(saidaFilePath) && new FileInfo(saidaFilePath).Length > 0)
            {
                StreamReader leitor = new(saidaFilePath);
                do
                {
                    string linha = leitor.ReadLine();
                    string[] vetorDados = linha.Split(";");
                    Veiculo veiculo = new(vetorDados[0], DateTime.Parse(vetorDados[1]), DateTime.Parse(vetorDados[2]), TimeSpan.Parse(vetorDados[3]), double.Parse(vetorDados[4]));

                    listaVeiculosSaida.Add(veiculo);

                } while (!leitor.EndOfStream);

                leitor.Close();
            }
        }

        public static void GravarArquivoEntrada(Veiculo veiculo)
        {
            StreamWriter escritor = new(entradaFilePath, true);
            escritor.WriteLine($"{veiculo.Placa};{veiculo.DataEntrada:d};{veiculo.HoraEntrada:t}");
            escritor.Close();
        }
        public static void AtualizarArquivoEntrada(List<Veiculo> listaVeiculos)
        {
            //lendo o arquivo de entrada e atualizando
            StreamWriter atualizaArquivo = new(entradaFilePath, false);
            foreach (var item in listaVeiculos)
            {
                atualizaArquivo.WriteLine($"{item.Placa};{item.DataEntrada:d};{item.HoraEntrada:t}");
            }
            atualizaArquivo.Close();
        }

        public static void GravarArquivoVeiculosSaida(Veiculo veiculo)
        {
            string tempoFormatado = veiculo.TempoPermanencia.ToString(@"hh\:mm\:ss");
            string dataEntradaFormatada = veiculo.DataEntrada.ToString(@"d");
            string horaEntradaFormatada = veiculo.HoraEntrada.ToString(@"t");

            StreamWriter escritor = new(saidaFilePath, true);
            escritor.WriteLine($"{veiculo.Placa};{dataEntradaFormatada};{horaEntradaFormatada};{tempoFormatado};{veiculo.ValorCobrado}");
            escritor.Close();
        }
    }
}
