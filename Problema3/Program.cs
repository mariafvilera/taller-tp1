namespace Problema3;

public class Program{

    public static void Main(string[] args){
        Console.WriteLine("Ingrese la cantidad de kilometros conducidos");
        float kilometros = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingre la cantidad de litros usados");
        float litros = Convert.ToInt32(Console.ReadLine());
        
        float kilometrosPorLitro;

        try{
            kilometrosPorLitro = kilometros / litros;
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }
        finally{
            Console.WriteLine("Kilometros por litro: " + kilometrosPorLitro);
        }
    }
}