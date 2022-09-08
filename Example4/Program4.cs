void FillArray (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random().Next(1, 10);
        index = index + 1;

    }
}

void PrintArray (int [] col)

{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position = position + 1;

    }
}


int [] array = new int [10];  //Определили произвольный массив, состоящий из 10 элементов

FillArray(array);            //Данный метод заполнил массив
PrintArray(array);          //Данный метод распечатал массив в консоли