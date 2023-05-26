//interface gr�fica: 
placa
botao entrada -> textBox data textBox hora
botao saida   -> 
textBoxListaVeiculosEntrada
textBoxListaVeiculosSaida
MessageBox.Show() -> Placa tempoPermanecia valorCobrado

//orienta��o a objetos
Veiculo 
   placa -> 7 caracteres -> verificar jaNaGaragem
   dataEntrada 
   horaEntrada
   dataSaida
   horaSaida
   tempoPermanecia
   valorCobrado


   Veiculo(placa) {
      ...
      gerarDataHora()
   }

   Veiculo(placa, dataEntrada, horaEntrada)

   gerarData()

   jaCadastrada(placa)

   temLugar()

//persistencia dos dados
Persistencia   
   lerArquivoVeiculosEntrada(listaEntrada)
   lerArquivoVeiculosSaida(listaSaida)
   gravarArquivoVeiculosEntrada(listaEntrada)
   gravarArquivoVeiculosSaida(listaSaida)


=================================================================

Construir um sistema em Visual Studio, C# e com Windows Form para entrada, sa�das de ve�culos e as devidas cobran�as.

A din�mica de funcionamento da garagem �:

1) das 7h �s 20h, todos os dias;
2) h� 50 vagas para ve�culos (carros, caminhonetes e motos). Assim, quando a garagem lotar, s� entra pr�ximo
   ve�culo se outro sair;
3) o valor da hora � R$ 5,00. Neste desafio, n�o ser� realizado/processado nada caso o ve�culo n�o seja retirado
   at� �s 20h. Se o ve�culo passar 1 minuto da hora, � cobrado a hora cheia. Por exemplo, tempo de 
   perman�ncia 123 minutos (2h e 3min), o sistema dever� cobrar por 3 horas;
4) h� uma interface gr�fica para o porteiro lan�ar a PLACA do ve�culo e indicar se � uma ENTRADA ou SA�DA.
   Neste sistema, � o porteiro que indica a hora de entrada e a hora de saida. A data � capturada automaticamente;
5) na interface gr�fica, h� um label para a data e outro para hora (para que o porteiro possa informar-se)
6) na interface gr�fica, h� duas regi�es (textBox de m�ltiplas linhas ou outro componenete que desear), 
   uma para a lista dos ve�culos que est�o na garagem, e outra para a lista dos ve�culos que sa�ram da garagem.
7) na interface gr�fica, a lista de ve�culos que est�o na garagem deve conter:
    placa - dataEntrada - horaEntrada
8) na interface gr�fica, a lista de ve�culos que sa�ram da garagem deve conter:
    placa - tempoPermanencia - valorCobrado

    O tempo de permanencia deve ser em minutos

9) toda vez que o porteiro lan�ar a placa como ENTRADA de ve�culo, o sistema deve adicionar a placa do ve�culo, dataEntrada e horaEntrada na lista de ve�culos de entrada (List, textBox e arquivo). 

10) toda vez que o porteiro lan�ar a placa como SA�DA de ve�culo, o sistema deve calcular o valor e mostrar isso em uma MessageBox (MessageBox.Show()) e adicionar a placa, tempoPermanencia e valor cobrado na lista de 
ve�culos de sa�da (List, textBox e arquivo);

Para persist�ncia dos dados vamos utilizar:
1) Ve�culos que est�o na garagem: TextBox (multiplas linhas) + List<Veiculos> + arquivo (veiculosEntrada.dat)
   O conte�do do arquivo veiculosEntrada.dat deve conter os dados organizados:
   placa;dataEntrada;horaEntrada

   Por exemplo, 
   IPL7154;09/06/2022;19:52


2) Ve�culos que sa�ram da garagem: TextBox (multiplas linhas) + List<Veiculos> + arquivo (veiculosSaida.dat)
   O conte�do do arquivo veiculosSaida.dat deve conter os dados organizados:
   placa;dataEntrada;horaEntrada;tempoPermanecia;valorCobrado

   Por exemplo, placa; 62 minutos ou 2 horas; 10 reais
   IPL7154;11/06/2022;12:34;62;10

Para o Classe Veiculo:
atributos: placaVeiculo, dataEntrada, horaEntrada, tempoPermanencia, valorCobrado
m�todos: construtor s� com placaVeiculo, dataEntrada, horaEntrada; getters e setters

Para a Classe de Persistencia:
m�todos de classe: l
    erArquivoVeiculosEntrada(); lerArquivoVeiculosSaida(); 
    gravarArquivoVeiculosEntrada(); gravarArquivoVeiculosSaida();

D�vidas, consultar o professor durante a aula reservada para o desafio.