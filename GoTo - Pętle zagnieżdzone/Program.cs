class Program
{





    static void Main(string[] args)
    {
       
    
        for(int i = 1; i <= 10; i++)
        {
            if(i == 4)
            {
                continue;
            }
            for (int j = 1; j <= 10; j++)
            {
                if(j == 5)
                {
                    continue;
                    
                }
                Console.WriteLine($"Jesteś w wierszu {i} i kolumnie {j}");
                Console.WriteLine();
            }
        }
    
    

    }
}