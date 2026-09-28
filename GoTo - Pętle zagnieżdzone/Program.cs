class Program
{





    static void Main(string[] args)
    {
       
    
        for(int i = 1; i <= 10; i++)
        {
            
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"Jesteś w wierszu {i} i kolumnie {j}");
                Console.WriteLine();
                if(i == 4 && j == 5)
                {
                    goto koniec;
                }
            }
        }
    koniec:
        Console.WriteLine("Zakończono pracę pętli");

    

    }
}