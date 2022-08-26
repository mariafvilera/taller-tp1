namespace Ejercicio3;

public enum EstadoCivil{
    Divociado,
    Casado,
    Soltero
}

public class Empleado{
    
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public string Direccion { get; private set;}
    public int CantidadHijos { get; private set; }
    
    public DateTime FechaIngreso { get; private set; }
    public DateTime FechaDivorcio { get; private set; }
    public EstadoCivil EstadoCivil { get; private set; }

    public int Antiguedad { get; private set;}
    public int Edad { get; private set;}
    public float Salario { get; private set; }
    
    private const float Descuento = 0.15f;

    public float CalcularSalario(){
        float Adicional;

        switch(Antiguedad){
            case Antiguedad <= 1:
                Adicional = 1;
                break;
            case Antiguedad <= 2:
                Adicional = 2;
                break;
            case Antiguedad <= 15:
                Adicional = 15;
                break;
        }
        return salario + (Antiguedad * Adicional) - (Descuento * Salario);
    }
}