namespace Problema1;

public class Program{
    public static void Main(string[] args){
        try{
            int entrada = Console.ReadLine();
            Console.WriteLine(entrada * entrada);
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }
    }
}