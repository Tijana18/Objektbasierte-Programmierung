namespace MyCars;

class Program
{

    public static void Main()
    {
        RaceCars car1 = new RaceCars();
        RaceCars car2 = new RaceCars("Audi", "A8", "Weis");
        RaceCars car3 = new RaceCars("Kia", "X10", 80, 9);
        RaceCars car4 = new RaceCars("BMW", "X4", 30, 4, "Tijana");
        
        RaceCars car5 = new RaceCars()
        {
            Marke = "Mazda",
            Modell = "X6",
            NameFahrer = "Novak",
            Höchsteschwindigkeit = 70
        };
        
    car1.Farbe = "blau";
        car1.Marke = "BMW";
        car1.Modell = "X6";
        //Positionale Argumente
        car1.Runde(4, "Zürich");
        car1.autoDaten();
        //Benannte Argumente
        car1.Runde(rundenZeit: 32, streckeName:"St.Gallen");
        car1.autoDaten();
        car1.Beschleunigen();
        car1.Beschleunigen(9);
        car1.autoDaten();
        
        car5.Bremsen(0);
        car5.autoDaten();
        car5.Beschleunigen(50);
        car5.Bremsen(20);
        car5.autoDaten();


    }
}