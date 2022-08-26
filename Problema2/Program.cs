Console.WriteLine("Ingrese el primer número");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número");
int numero2 = Convert.ToInt32(Console.ReadLine());

try{
    int division = numero1 / numero2;
}
catch(Exception ex){
    Console.WriteLine(ex);
}

Console.WriteLine("Resultado " + division);