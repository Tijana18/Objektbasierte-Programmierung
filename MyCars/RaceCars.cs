namespace MyCars;

public class RaceCars
{

    /* 1. Weshalb sind diese Felder Instanzvariablen?
       Weil sie zu einem bestimmten Objekt gehören und den individuellen Zustand des Objekts speichern. Jedes Objekt kann unterschiedliche Werte haben.
       2. Weshalb sollten die Felder nicht öffentlich sein?
       Die Felder sollten nicht öffentlich sein, damit man von außen nicht direkt auf sie zugreifen und sie unkontrolliert verändern kann. Deshalb verwendet man private und Getter/Setter.
    */
    private int aktuelleGeschwindigkeit; //currentSpeed
    private int hochstGeschwindigkeit; // maxSpeed
    private int anzahlGefahrenerRunden; //number of laps

    public string Marke { get; set; }
    public string Modell { get; set; }
    public string Farbe { get; set; }
    public string NameFahrer { get; set; }
    public int startNumber { get; set; }

    /*Die Konstruktoren sind überladen, weil sie unterschiedliche Parameter besitzen.
    Die Konstruktoren besitzen unterschiedliche Signaturen,
    weil sie sich in Anzahl und Datentypen der Parameter unterscheiden. */
    public RaceCars()
    {
        
    }

    public RaceCars(string marke, string modell, string farbe)
    {
        this.Marke = marke;
        this.Modell = modell;
        this.Farbe = farbe;
    }

    public RaceCars(string marke, string modell, int hochstGeschwindigkeit, int startNumber)
    {
        // Der dritte Konstruktor ruft den zweiten Konstruktor mit : this.Marke auf.
        this.Marke = marke;
        this.Modell = modell;
        this.hochstGeschwindigkeit  = hochstGeschwindigkeit;
        this.startNumber = startNumber;
    }
    public RaceCars(string marke, string modell, int hochstGeschwindigkeit, int startNumber , string nameFahrer)
    {
        this.Marke = marke;
        this.Modell = modell;
        this.hochstGeschwindigkeit  = hochstGeschwindigkeit;
        this.startNumber = startNumber;
        this.NameFahrer = nameFahrer;
    }
    
    public int Höchsteschwindigkeit
    {
        get => hochstGeschwindigkeit;
        set
        {
            if (value > 0 && value >= hochstGeschwindigkeit)
                hochstGeschwindigkeit = value;
        } 
    }
    
    //Hochst Geschwindigkeit
    public int ektuelleGeschwindigkeit
    {
        get => aktuelleGeschwindigkeit;
        
        /* Ich habe einen Try-Catch-Block verwendet, um eine Exception abzufangen.
         Wenn ein ungültiger Wert eingegeben wird, wird eine Exception ausgelöst. 
         Der Catch-Block fängt diese Exception ab, damit das Programm nicht abstürzt.*/
        set
        {
            try
            {
                if (aktuelleGeschwindigkeit > 0 && value <= hochstGeschwindigkeit)
                    aktuelleGeschwindigkeit = value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
    //Beschleunigen(int)
    public void Beschleunigen(int geschwindigkeit)
    {
        this.aktuelleGeschwindigkeit += geschwindigkeit;
    }
    
    public void Beschleunigen()
    {
        this.aktuelleGeschwindigkeit += 20;
    }
   
    
    
    //Bremsen(int)
    public void Bremsen(int geschwindigkeit)
    {
        this.hochstGeschwindigkeit -= geschwindigkeit;
    }
    //Runde(int ,string)
    public void Runde(int rundenZeit,string streckeName){
        anzahlGefahrenerRunden++;
    }
    //autoDaten()
    /*Ich habe die Anforderung hier ein wenig verändert,
    um `switch` und die Eingabe von Daten auszuprobieren.
    
    public void AutoDaten(bool ausführlich = 1)
    {
        if (ausführlich == 1)
        {
            Console.WriteLine($"Marke: {Marke}");
            Console.WriteLine($"Modell: {Modell}");
            Console.WriteLine($"Farbe: {Farbe}");
            Console.WriteLine($"Höchstgeschwindigkeit: {Höchstgeschwindigkeit}");
            Console.WriteLine($"Aktuelle Geschwindigkeit: {aktuelleGeschwindigkeit}");
            Console.WriteLine($"Anzahl gefahrener Runden: {anzahlGefahrenerRunden}");
        }
        else
        {
            Console.WriteLine($"Marke: {Marke}, Modell: {Modell}");
        }
    }
    
        car1.AutoDaten();       ---> ohne optionalen Parameter
        car1.AutoDaten(2);    ---> mit ausdrücklich übergebenem Wert */
    public void autoDaten()
    {
        Console.WriteLine(
            "Möchten Sie alle Daten oder nur Anzahl Gefahrener Runden? \n Wehlen Sie nummer: \n 1. Anzahl Gefahrener Runden. \n 2. Alle Daten."); 
        int number = int.Parse(Console.ReadLine());

            if (number == 1 || number == 2)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine($"Anzahl Gefahrener Runden: {anzahlGefahrenerRunden}");
                        break;
                    case 2:
                        Console.WriteLine($"Marke: {Marke} \n" +
                            $"Modell: {Modell} \n" +
                            $"Farbe: {Farbe} \n" +
                            $"Anzahl Gefahrener Runde: {anzahlGefahrenerRunden} \n" +
                            $"Aktuelle Geschwindigkeit: {aktuelleGeschwindigkeit} \n" +
                            $"Start nummber: {startNumber}");
                        break;
                }
            }
            else
            {
                    Console.WriteLine("Bitte wehlen Sie number 1 oder 2!!!");
                    autoDaten();
            }
    }
    
    
    
}

