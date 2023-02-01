using NakladakDemo;

Truck kamion = new Truck(10000);
Random rand = new Random();
while (true)
{
    Console.Clear();
    ZobrazKamion(kamion);
    System.Threading.Thread.Sleep(2000);
    if(rand.NextDouble() < 0.5)
    {
        int naklad = rand.Next(1000, 4000);
        Console.WriteLine($"Vykládám: {naklad}kg");
        if (kamion.UnLoad(naklad))
        {
            Console.WriteLine("Vyloženo");
        }
        else
        {
            Console.WriteLine("Nevyloženo");
        }        
    }
    else
    {
        int naklad = rand.Next(1000, 4000);
        Console.WriteLine($"Nakládám: {naklad}kg");
        int nalozeno = kamion.Load(naklad);
        Console.WriteLine($"Naloženo {nalozeno}kg");
    }
    System.Threading.Thread.Sleep(2000);
}


static void ZobrazKamion(Truck truck)
{
    Console.WriteLine($"Kamion - Max nosnost: {truck.MaxLoad}kg");
    Console.WriteLine($"Kamion - aktuální náklad: {truck.ActualLoad}kg");
}