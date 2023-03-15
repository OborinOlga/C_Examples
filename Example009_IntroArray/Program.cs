int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//                0   1   2   3   4   5   6   7   8   
int[] massive = { 11, 211, 31, 41, 15, 15, 61, 17, 18 };
// massive [4] = 112;
// Console.WriteLine(massive [4]);

int max = Max(
Max(massive[0], massive[1], massive[2]),
Max(massive[3], massive[4], massive[5]),
Max(massive[6], massive[7], massive[8])
);
Console.WriteLine(max);