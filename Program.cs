using Colecoes.Helper;

OperacoesArray op = new OperacoesArray();

int[] array = new int[5] { 6, 3, 8, 1, 9 };
int[] arrayCopia = new int[10];

int valorProcurado = 3;

System.Console.WriteLine("Capacidade atual do array: " + array.Length);
op.RedimensionarArray(ref array, array.Length * 2);

System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

// int indice = op.ObterIndice(array, valorProcurado);

// if(indice > -1)
// {
//     System.Console.WriteLine($"O indice do elemento {valorProcurado} é: {indice}");
// }
// else
// {
//     System.Console.WriteLine("Valor não encontrado no array");
// }

// int valorAchado = op.ObterValor(array, valorProcurado);

// if(valorAchado > 0)
// {
//     System.Console.WriteLine("Encontrei o valor ");
// }
// else
// {
//     System.Console.WriteLine("Não encontrei o valor ");
// }

// bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

// if (todosMaiorQue)
// {
//     System.Console.WriteLine("Todos os valores são maiores que: {0}", valorProcurado);
// }   
// else
// {
//     System.Console.WriteLine("Existe valores que não são maiores que: {0}", valorProcurado);
// }

// bool exixte = op.Existe(array, valorProcurado);

// if (exixte)
// {
//     System.Console.WriteLine("Existe: {0}", valorProcurado);
// }
// else
// {
//     System.Console.WriteLine("Não existe: {0}", valorProcurado);
// }


//System.Console.WriteLine("Array original: ");
//op.ImprimirArray(array);

//op.OrdernarBubbleSort(ref array);
//op.Ordernar(ref array);

//System.Console.WriteLine("Array ordenado: ");
//op.ImprimirArray(array);

// System.Console.WriteLine("Array antes da cópia: ");
// op.ImprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);
// System.Console.WriteLine("Array depois da cópia: ");
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
//         System.Console.WriteLine(matriz[i,j]);
//     }
// }

//matriz[0,0] = 5;


// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = int.Parse("30");
// arrayInteiros[3] = 40;

// System.Console.WriteLine("Percorrenco o array pelo for");

// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     System.Console.WriteLine(arrayInteiros[i]);
// }

// System.Console.WriteLine("Percorrendo o array pelo foreach");
// foreach (var intem in arrayInteiros)
// {
//     System.Console.WriteLine(intem);
// }
