using Colecoes.Helper;

OperacoesArray op = new OperacoesArray();
int[] array = new int[10] { 6, 3, 8, 1, 9 , 2, 5, 4, 7, 0 };

System.Console.WriteLine("Array original: ");
op.ImprimirArray(array);

//op.OrdernarBubbleSort(ref array);
op.Ordernar(ref array);

System.Console.WriteLine("Array ordenado: ");
op.ImprimirArray(array);

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
