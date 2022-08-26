using System.Net;
using System.Text.Json;

namespace Problema4;

public static class ServicioConexion
{
    private const string TipoContenido = "application/json";
    private const string ApiUrl = "https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
    private const string Metodo = "GET";
        
    public static Root? VerResultadosApi()
    {
        Root raiz;
        
        var request = (HttpWebRequest) WebRequest.Create(ApiUrl);
        request.Method = Metodo;
        request.ContentType = TipoContenido;
        request.Accept = TipoContenido;

        try
        {
            using WebResponse respuestaWeb = request.GetResponse();
            using Stream stream = respuestaWeb.GetResponseStream(); 
            using var streamReader = new StreamReader(stream);
            
            string responseBody = streamReader.ReadToEnd();
            raiz = JsonSerializer.Deserialize<Root>(responseBody);
            
        }catch(WebException e){
            Console.WriteLine(e.ToString());
            throw e;
        }

        return raiz;
    }
}