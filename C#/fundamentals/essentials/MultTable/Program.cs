using System;

namespace MultTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] multTable = new int[10,10];
            int row = 1;
            for (int i = 0; i < multTable.GetLength(0); i++)
            {
                string display = "[";
                int datum = row;
                for (int j = 0; j < multTable.GetLength(0); j++)
                {
                    multTable[i,j] = datum;
                    if(j == multTable.GetLength(0) -1){
                        display += $"{datum}";
                    }
                    else{
                        display += $"{datum}, ";
                    }
                    datum += row;
                }
                display += "]";
                Console.WriteLine(display);
                row +=1;
            }
        }
    }
}
