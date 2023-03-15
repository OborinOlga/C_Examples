int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(result < arg2) result = arg2;
    if(result < arg3) result = arg3;
    return result;
}


int a1 = 13;
int b1 = 100;
int c1 = 5;

int a2 = 10;
int b2 = -7;
int c2 = 2;

int a3 = 4;
int b3 = 11;
int c3 = 19;


// int max1 = Max (a1, b1, c1);
// int max2 = Max (a2, b2, c2);
// int max3 = Max (a3, b3, c3);
// int max = Max (max1, max2, max3);

int max = Max(
    Max (a1, b1, c1),
    Max (a2, b2, c2),
    Max (a3, b3, c3));

Console.Write("max = ");
Console.WriteLine(max);
