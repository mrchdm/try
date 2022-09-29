Console.WriteLine("Сколько элементов в массиве вы хотите видеть");
int a = Convert.ToInt32(Console.ReadLine());

string[] array = new string[a];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToString(Console.ReadLine());

}
