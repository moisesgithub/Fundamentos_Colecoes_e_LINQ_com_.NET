using Colecoes.Helper;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
   //Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string valorProcurado = "ES";

//var teste = estados["SC"];

if (estados.TryGetValue(valorProcurado, out var estadoEncontrado))
{
   Console.WriteLine(estadoEncontrado);
}
else
{
   Console.WriteLine($"Chave {valorProcurado} não existe no dicionário!");
}


// Console.WriteLine($"Removendo o Valor : {valorProcurado}");

// estados.Remove(valorProcurado);

// foreach (var item in estados)
// {
//    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("Valor original");
// Console.WriteLine(estados[valorProcurado]);

// estados[valorProcurado] = "SP - teste atualização";

// Console.WriteLine("Valor Atualizado");
// Console.WriteLine(estados[valorProcurado]);

// Stack<string> pilhaLivros = new Stack<string>();

// pilhaLivros.Push("O Senhor dos Anéis");
// pilhaLivros.Push("O Hobbit");
// pilhaLivros.Push("A Roda do Tempo");

// Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");

// while (pilhaLivros.Count > 0)
// {
//   System.Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
//   System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
// }
// Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");

// Queue<string> fila = new Queue<string>();

// fila.Enqueue("Moises");
// fila.Enqueue("Nicolly");
// fila.Enqueue("Natiara");

// Console.WriteLine($"Pessoas na fila: {fila.Count}");

// while(fila.Count > 0)
// {
//   Console.WriteLine($"Vez de: {fila.Peek()}");
//   Console.WriteLine($"{fila.Dequeue()} atendido");
// }
// Console.WriteLine($"Pessoas na fila: {fila.Count}");

// OperacoesLista opLista = new OperacoesLista();
// List<string> estados = new List<string> {"SP", "MG", "BA", "ES", "RN", "CE"};
// string[] estadoArray = new string[2] { "RJ", "SP" };


// Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
// opLista.ImprimirListaString(estados);

// Console.WriteLine("Removendo o elemento da lista");
// estados.Remove("RJ");

// estados.AddRange(estadoArray);
// estados.Insert(1, "RJ");

// opLista.ImprimirListaString(estados);


// OperacoesArray op = new OperacoesArray();

// int[] array = new int[5] { 6, 3, 8, 1, 9 };
// int[] arrayCopia = new int[10];
// string[] arrayString = op.ConverterParaArrayString(array);

// //int valorProcurado = 3;

// Console.WriteLine("Capacidade atual do array: " + array.Length);

// op.RedimensionarArray(ref array, array.Length * 2);

// Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

// int indice = op.ObterIndice(array, valorProcurado);

// if(indice > -1)
// {
//     Console.WriteLine($"O indice do elemento {valorProcurado} é: {indice}");
// }
// else
// {
//     Console.WriteLine("Valor não encontrado no array");
// }

// int valorAchado = op.ObterValor(array, valorProcurado);

// if(valorAchado > 0)
// {
//     Console.WriteLine("Encontrei o valor ");
// }
// else
// {
//     Console.WriteLine("Não encontrei o valor ");
// }

// bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

// if (todosMaiorQue)
// {
//     Console.WriteLine("Todos os valores são maiores que: {0}", valorProcurado);
// }   
// else
// {
//     Console.WriteLine("Existe valores que não são maiores que: {0}", valorProcurado);
// }

// bool exixte = op.Existe(array, valorProcurado);

// if (exixte)
// {
//     Console.WriteLine("Existe: {0}", valorProcurado);
// }
// else
// {
//     Console.WriteLine("Não existe: {0}", valorProcurado);
// }

//Console.WriteLine("Array original: ");
//op.ImprimirArray(array);

//op.OrdernarBubbleSort(ref array);
//op.Ordernar(ref array);

//Console.WriteLine("Array ordenado: ");
//op.ImprimirArray(array);

// Console.WriteLine("Array antes da cópia: ");
// op.ImprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);
// Console.WriteLine("Array depois da cópia: ");
// op.ImprimirArray(arrayCopia);

// int[,] matriz = new int[4,2]
// {
//     {10,2},
//     {30,4},
//     {5,60},
//     {70,8}
// };//matriz já inicializada

// for (int i = 0; i < matriz.GetLength(0); i++)
// {
//     for (int j = 0; j < matriz.GetLength(1); j++)
//     {
//         Console.WriteLine(matriz[i,j]);
//     }
// }

//matriz[0,0] = 5;

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = int.Parse("30");
// arrayInteiros[3] = 40;

// Console.WriteLine("Percorrenco o array pelo for");

// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     Console.WriteLine(arrayInteiros[i]);
// }

// Console.WriteLine("Percorrendo o array pelo foreach");
// foreach (var intem in arrayInteiros)
// {
//     Console.WriteLine(intem);
// }
