namespace PromilleRechner2;

public class Spruch
{
    private double _alkoholPromille;

    public Spruch(double alkoholPromille)
    {
        _alkoholPromille = alkoholPromille;
    }

    public string ErhalteSpruch()  
    {
        if (_alkoholPromille > 0.5)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return $"--------------------------------\nSie sind nicht mehr fahrtüchtig\nPromille: {_alkoholPromille}";
        }
        Console.ForegroundColor = ConsoleColor.Green;
        return $"--------------------------------\nSie sind immernoch fahrtüchtig\nPromille: {_alkoholPromille}";
        
    }
}