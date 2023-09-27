public static int DiaDiff(List<List<int>> arr)
{
    int rows = arr.Count;

    int priSum = 0;
    int secSum = 0;

    for (int i = 0; i < rows; i++)
    {
        priSum += arr[i][i];
        secSum += arr[i][rows - 1 - i];
    }

    return Math.Abs(priSum - secSum);

}
