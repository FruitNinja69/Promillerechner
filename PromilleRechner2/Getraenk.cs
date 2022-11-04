namespace PromilleRechner2;

public class Getraenk
{
    public const double BIER_ALKOHOLGEHALT = 0.05;
    public const double WEIN_ALKOHOLGEHALT = 0.10;
    public const double SCHNAPS_ALKOHOLGEHALT = 0.40;
    public const double DICHTE_ALKOHOL = 0.8;
    
    private int _volumenInMilliliter;
    private double _alkoholGehalt;
    private DateTime _getrunkenAm;

    public double StundenSeitEinnahme
    {
        get => DateTime.Now.Subtract(_getrunkenAm).Hours;
    }
    
    public double AlkoholMasseInGramm
    {
        get => _volumenInMilliliter * _alkoholGehalt * DICHTE_ALKOHOL;
    }

    public Getraenk(int volumenInMilliliter, double alkoholGehalt, DateTime getrunkenAm)
    {
        _volumenInMilliliter = volumenInMilliliter;
        _getrunkenAm = getrunkenAm;
        if (alkoholGehalt == 1)
        {
            _alkoholGehalt = BIER_ALKOHOLGEHALT;
        }
        else if (alkoholGehalt == 2)
        {
            _alkoholGehalt = WEIN_ALKOHOLGEHALT;
        } else if (alkoholGehalt == 3)
        {
            _alkoholGehalt = SCHNAPS_ALKOHOLGEHALT;
        }
    }
}