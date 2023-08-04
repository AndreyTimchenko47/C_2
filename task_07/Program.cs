int[] array ={11, 12, 123, 3213, 123, 323, 322, 1112, 444};

int n =array.Length; // определяет количество элементов в массиве
int find = 323;
int index =0;

while(index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерывает итерации  при нахождении первого индекса с максимальным числом если их несколько одинаковых
    }
    index++;
}


