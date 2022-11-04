namespace PromilleRechner2;

public class PromilleRechner
{
    private Person FragePersonDaten()
    {
        Console.WriteLine("Tippen Sie '0' für männlich oder '1' für weiblich: ");
        int geschlecht = int.Parse(Console.ReadLine());
        Console.WriteLine("________________________________________________________");

        Console.WriteLine("Geben Sie ihre Grösse in cm ein: ");
        double grösse = double.Parse(Console.ReadLine());
        Console.WriteLine("________________________________________________________");

        Console.WriteLine("Geben Sie ihr Gewicht in kg ein: ");
        double gewicht = double.Parse(Console.ReadLine());
        Console.WriteLine("________________________________________________________");

        Console.WriteLine("Geben Sie ihr Geburtsdatum ein: ");
        DateTime geburtsdatum = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("________________________________________________________");

        Person person = new Person(gewicht, grösse, geburtsdatum, geschlecht);
        return person;
    }

    private Getraenk FrageGetraenkeDaten()
    {
        Console.WriteLine("Was für ein Getränk haben Sie getrunken. Tippen Sie 1 für Bier, 2 für Wein und 3 für Schnaps: ");
        int getraenkeArt = int.Parse(Console.ReadLine());
        Console.WriteLine("________________________________________________________");

        Console.WriteLine("Geben Sie Trinkdatum und -zeit ein (yyyy/mm/dd hh:mm): ");
        DateTime getrunkenAm = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("________________________________________________________");

        Console.WriteLine("Geben Sie die getrunkene Menge in Milliliter an: ");
        int volumenInMillimeter = int.Parse(Console.ReadLine());
        Console.WriteLine("________________________________________________________");


        Getraenk getraenk = new Getraenk(volumenInMillimeter, getraenkeArt, getrunkenAm);
        return getraenk;
    }
    
    public void BerechnePromille()
    {
        Person person = FragePersonDaten();
        Getraenk getraenk = FrageGetraenkeDaten();
        person.Trinke(getraenk);
        Spruch spruch = new Spruch(person.AlkoholPromille);
        Console.WriteLine(spruch.ErhalteSpruch());
    }
}