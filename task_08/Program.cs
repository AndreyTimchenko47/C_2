int[] array = new int [10]; // создаем массив с 10 индексами

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position =-1; // не ноль так как -1 служит индикатором что искомого числа в массиве нет
    while(index<count)
    {
        if(collection[index]==find)
        {
        position= index;
        break;
        }
        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos =Indexof(array, 4);// показывает индекс числа 4 если оно имеется в массиве
Console.WriteLine(pos);