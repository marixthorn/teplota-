int[] poleT = new int [31];
Console.WriteLine("Zadej teplotu");
for (int i = 0; i < 31; i++) 
{
    poleT[i] = int.Parse(Console.ReadLine());
}
// Cyklus na zadání teplot 
Console.WriteLine("Co mám vypsat?");
Console.WriteLine("Největší teplotu,nejmenší nebo průměr?");
string teplota = Console.ReadLine();
// Výběr co to vypíše
if ( teplota == "Nejmenší")

{

    int min = poleT[0];
        foreach (int i in poleT)
    {
        min = Math.Min(min, i);
    }

    Console.WriteLine(min);
}
// Vypíše max teplotu 

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
// Vypíše max teplotu 
else
{
    double avrg = poleT[0];
    foreach (int i in poleT)
    {
        avrg = poleT.Average();
    }
    Console.WriteLine("Průměr teplot je:" + avrg);
}
//Vypíše průměrnou teplotu