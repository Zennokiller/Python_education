// Задаем массив
string[] massiv_A = {"hello","2","world",":-)"};
// Вывод массива с подсчетом в нем нужных нам элементов
Console.WriteLine("Исходный массив");
int num_massiv_B = 0; //количество элементов в будующем массиве
int j = 0;
//string[] massiv_B = Array.Empty<string>();
for (int i=0;i<massiv_A.Length;i++
{
    Console.WriteLine(massiv_A[i]+" ");
    if (massiv_A[i].Length<=3) num_massiv_B++; //считаем сколько в массиве нужных нам элементов
}
Console.WriteLine("Полученный массив");
if (num_massiv_B==0) Console.WriteLine("[]");
if (num_massiv_B>0) 
{
    string[] massiv_B = new string[num_massiv_B];
    for (int i=0;i<massiv_A.Length;i++)
    {
    if (massiv_A[i].Length<=3) 
    {
        massiv_B[j]=massiv_A[i]; 
        Console.WriteLine(massiv_B[j]+" ");
        j++;
    }
    }   
}


