//Нахождение максимума среди целых чисел.
//Решение задачи с использованием функции.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 23;
int b1 = 11;
int c1 = 90;

int a2 = 113;
int b2 = 101;
int c2 = 900;

int a3 = 243;
int b3 = 151;
int c3 = 9;

int Max1 = Max(a1, b1, c1);
int Max2 = Max(a2, b2, c2);
int Max3 = Max(a3, b3, c3);
int maxFinal = Max(Max1, Max2, Max3);

Console.WriteLine(maxFinal);



