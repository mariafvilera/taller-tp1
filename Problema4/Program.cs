namespace Problema4;

public class Program
{

    public static void Main(string[] args){

        try
        {
            Root raizAPI = ServicioConexion.VerResultadosApi();
            Console.WriteLine("Información Provincias");

            foreach(Provincia provincia in raizAPI.provincias)
            {
                Console.WriteLine("ID: " + provincia.id);
                Console.WriteLine("Nombre: " + provincia.nombre);
            }
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }
    }
}