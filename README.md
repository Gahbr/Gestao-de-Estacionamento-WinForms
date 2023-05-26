# Sistema de Controle de Entrada e Saída de Veículos em uma Garagem

Este é um projeto desenvolvido em Visual Studio, utilizando C# e Windows Forms, que implementa um sistema de controle de entrada, saída e cobrança de veículos em uma garagem. Ele foi proposto durante a Academia .NET da ATOS/UFN

## Design

## Funcionalidades

1. Funcionamento das 7h às 20h, todos os dias.
2. Limite de 50 vagas para veículos. A entrada de novos veículos só é permitida se houver uma vaga disponível.
3. Cobrança de R$ 5,00 por hora de permanência. Se um veículo ultrapassar 1 minuto após uma hora completa, será cobrado o valor da hora cheia.
4. Interface gráfica para o porteiro registrar a placa do veículo e indicar se é uma entrada ou saída.
5. Captura automática da data atual na interface gráfica.
6. Listas visuais para exibir os veículos presentes na garagem e os veículos que saíram.
7. A lista de veículos presentes na garagem exibe a placa, data de entrada e hora de entrada.
8. A lista de veículos que saíram exibe a placa, tempo de permanência e valor cobrado.
9. Registro automático dos veículos de entrada na lista de veículos presentes na garagem (List, TextBox e arquivo).
10. Cálculo do valor cobrado e exibição em uma MessageBox quando um veículo é registrado como saída. Os dados do veículo são adicionados à lista de veículos que saíram (List, TextBox e arquivo).

## Persistência de Dados

Para persistência dos dados, o projeto utiliza arquivos e listas para armazenar as informações dos veículos.

1. Veículos presentes na garagem: TextBox (múltiplas linhas) + List<Veiculos> + arquivo (veiculosEntrada.dat)
   - O arquivo veiculosEntrada.dat armazena os dados dos veículos que estão presentes na garagem no formato:
     placa;dataEntrada;horaEntrada
   - Exemplo de conteúdo do arquivo veiculosEntrada.dat:
     ```
     IPL7154;09/06/2022;19:52
     ```

2. Veículos que saíram da garagem: TextBox (múltiplas linhas) + List<Veiculos> + arquivo (veiculosSaida.dat)
   - O arquivo veiculosSaida.dat armazena os dados dos veículos que saíram da garagem no formato:
     placa;dataEntrada;horaEntrada;tempoPermanecia;valorCobrado
   - Exemplo de conteúdo do arquivo veiculosSaida.dat:
     ```
     IPL7154;11/06/2022;12:34;62;10
     ```

## Classes

### Classe Veiculo
- Atributos: placaVeiculo, dataEntrada, horaEntrada, tempoPermanencia, valorCobrado
- Métodos: construtor com placaVeiculo, dataEntrada e horaEntrada; getters e setters dos atributos

### Classe de Persistencia
- Métodos de classe: lerArquivoVeiculosEntrada(), lerArquivoVeiculosSaida(), gravarArquivoVeiculosEntrada(), gravarArquivoVeiculosSaida()
