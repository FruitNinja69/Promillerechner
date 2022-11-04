namespace PromilleRechner2;

public class Person
{
    public const int MAENNLICH = 0;
    public const int WEIBLICH = 1;
    private const double ABBAU_WARTEZEIT_STUNDEN = 1.0;
    private const double ABBAU_PRO_STUNDE = 0.1;    
    private const double ANTEIL_WASSER_IM_BLUT = 0.8;
    private const double DICHTE_BLUT_GRAMM_PRO_CCM = 1.055;
    
    private double _koerperMasse;
    private double _koerperGroesseInCm;
    private DateTime _geburtsDatum;
    private int _geschlecht;
    private double _alkoholPromille = 0.0;

    public double AlterInJahren
    {
        get => DateTime.Now.Year - _geburtsDatum.Year;
    }

    public double AlkoholPromille
    {
        get => _alkoholPromille;
    }

    public double GKW
    {
        get
        {
            double result = 0.0;
            
            if (_geschlecht == MAENNLICH)
            {
                result = 2.447 - 0.09516 * AlterInJahren + 0.1074 * _koerperGroesseInCm + 0.3362 * _koerperMasse;
            }
            else if (_geschlecht == WEIBLICH)
            {
                result = 0.203 - 0.07 * AlterInJahren + 0.1069 * _koerperGroesseInCm + 0.2466 * _koerperMasse;
            }

            return result;
        }
    }

    public Person(double koerperMasse, double koerperGroesseInCm, DateTime geburtsDatum, int geschlecht)
    {
        _koerperMasse = koerperMasse;
        _koerperGroesseInCm = koerperGroesseInCm;
        _geburtsDatum = geburtsDatum;
        _geschlecht = geschlecht;
    }

    public void Trinke(Getraenk getraenk)
    {
        _alkoholPromille = ANTEIL_WASSER_IM_BLUT * getraenk.AlkoholMasseInGramm / (DICHTE_BLUT_GRAMM_PRO_CCM * GKW);

        if (getraenk.StundenSeitEinnahme > ABBAU_WARTEZEIT_STUNDEN)
        {
            _alkoholPromille -= (getraenk.StundenSeitEinnahme - ABBAU_WARTEZEIT_STUNDEN) * ABBAU_PRO_STUNDE + 0.05;
        }
    }
}