int Max(int arg1, int arg2, int arg3)
{
    int result =arg1;
    if(arg2> result) result =arg2;
    if(arg3> result) result =arg3;
    return result;
}

int a1 = 22;
int a2 = 13;
int a3 = 9;
int a4 = 232;
int a5 = -8;
int a6 = 1;
int a7 = 0;
int a8 = -47;
int a9 = 21;

// int max1 =Max(a1, a2, a3);
// int max2 =Max(a4, a5, a6);
// int max3 =Max(a7, a8, a9);
// int max =Max(max1, max2, max3);
int max =Max(Max(a1, a2, a3), Max(a4, a5, a6), Max(a7, a8, a9));

Console.WriteLine($"Максимальное число max = {max}");

