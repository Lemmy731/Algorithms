public class Program
{
    public static void DiagonalDifference(List<List<int>> arr)
    {
        //List<List<int>> arr represent list of lists which is dynamic can also be used to create a 2 dimensional array
        int size = arr.Count;
        //to get the rows of the square matrix i.e a sqaure matrix has the same number of rows and columns
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;

        for (int i = 0; i < size; i++)
        {
            primaryDiagonalSum += arr[i][i]; // Sum of elements in the primary diagonal
            secondaryDiagonalSum += arr[i][size - 1 - i]; // Sum of elements in the secondary diagonal
        }

        int absoluteDifference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        Console.WriteLine(absoluteDifference);
    }
    public static void Main(string[] args) 
    {

        List<List<int>> sqrMat = new List<List<int>>();

        List<int> list1 = new List<int> { 2, 2, 90, 4, 5 };
        List<int> list2 = new List<int> { 6, 7, 54, 9, 10 };
        List<int> list3 = new List<int> { 11, 1, 13, 14, 15 };
        List<int> list4 = new List<int> { 1, 1, 53, 19, 20 };
        List<int> list5 = new List<int> { 21, 2, 23, 24, 25 };

        sqrMat.Add(list1);
        sqrMat.Add(list2);
        sqrMat.Add(list3);
        sqrMat.Add(list4);
        sqrMat.Add(list5);


        DiagonalDifference(sqrMat);
    }
}

