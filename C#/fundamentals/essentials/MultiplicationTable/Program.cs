// See https://aka.ms/new-console-template for more information
int [,] multTable = new int[10,10];

for (int i = 0; i < multTable.Length; i++)
{
    int row = 1;
    int datum = row;
    for (int j = 0; j < multTable.Length; j++)
    {
        multTable[i,j] = datum;
        Console.WriteLine(multTable[i,j]);
        datum += row;
    }
    row +=1;
}

