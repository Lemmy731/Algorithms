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
        int[] Delete = new int[9];
        int num = 0;

        for(int i =0; i < 9; i++)
        {
            Delete[i] = i;
            num++;
            //Console.WriteLine(Delete[i]);
        }

        // Console.WriteLine(num);
        
        int len = Delete.Length / 4;
        int lent = Delete.Length - 1;
        

        for (int i = 2; i <= lent; i++)
        {
           
            Delete[i -1] = Delete[i];
         

        }


        IEnumerable<int> uniqueNumbers = Delete.Distinct();
        //Delete[len] = Delete[len + 1];
        foreach (int i in uniqueNumbers)
        {
            Console.WriteLine(i);
        }

        //while (num < 2)
        //{

        //    //};

        }
}

