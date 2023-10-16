using PatronDecorator;

class Program
{
    static void Main(string[] args)
    {

        ICafe cafeBasico = new CafeBa();
        Console.WriteLine("Descripción: " + cafeBasico.ObtenerDescripcion());
        Console.WriteLine("Costo: $" + cafeBasico.ObtenerCosto());

        ICafe cafeConLeche = new LecheDecorator(new CafeBa());
        Console.WriteLine("Descripción: " + cafeConLeche.ObtenerDescripcion());
        Console.WriteLine("Costo: $" + cafeConLeche.ObtenerCosto());

        ICafe cafeConLecheYCaramelo = new CarameloDecorator(new LecheDecorator(new CafeBa()));
        Console.WriteLine("Descripción: " + cafeConLecheYCaramelo.ObtenerDescripcion());
        Console.WriteLine("Costo: $" + cafeConLecheYCaramelo.ObtenerCosto());

        ICafe cafeSinLeche = new CarameloDecorator(new CafeBa());
        Console.WriteLine("Descripción: " + cafeSinLeche.ObtenerDescripcion());
        Console.WriteLine("Costo: $" + cafeSinLeche.ObtenerCosto());

        Console.ReadLine();
    }
}