Console.WriteLine("Сколько элементов в массиве вы хотите видеть");
int a = Convert.ToInt32(Console.ReadLine());

string[] array = new string[a];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToString(Console.ReadLine());

}

string[] Newarray = new string[a];
int j = 0;
for (int m = 0; m < array.Length; m++)
{
    if (array[m].Length <= 3)
    {
        Newarray[j] = array[m];
    }
    Console.Write($"{Newarray[j]} ");
    j++;
}
