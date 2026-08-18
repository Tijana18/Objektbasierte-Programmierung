using System;

class Program
{
    // GGT berechnen
    static int GGT(int a, int b)
    {
        while (b != 0)
        {
            int rest = a % b;
            a = b;
            b = rest;
        }
        return a;
    }
    
    // KGV berechnen
    static int KGV(int a, int b)
    {
        return Math.Abs(a * b) / GGT(a, b);
    }
    static void Main()
    {
        //Wir nehmen input von user
        Console.Write("Gib die erste Zahl ein: ");
        int zahl1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Gib die zweite Zahl ein: ");
        int zahl2 = Convert.ToInt32(Console.ReadLine());

        int ggt = GGT(zahl1, zahl2);
        int kgv = KGV(zahl1, zahl2);

        Console.WriteLine("GGT = " + ggt);
        Console.WriteLine("KGV = " + kgv);
        
    }
}