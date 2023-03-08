int[] poleT = new int [31];
Console.WriteLine("Zadej teplotu");
for (int i = 0; i < 31; i++) 
{
    poleT[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Co mám vypsat?");
Console.WriteLine("Největší teplotu,nejmenší nebo průměr?");
string teplota = Console.ReadLine();

if ( teplota == "Nejmenší")

{

    int min = poleT[0];
        foreach (int i in poleT)
    {
        min = Math.Min(min, i);
    }

    Console.WriteLine(min);
}

else if
     (teplota == "Největší")

    {

        int max = poleT[0];
        foreach (int i in poleT)
        {
           max = Math.Max (max, i);
        }

        Console.WriteLine(max);
}
