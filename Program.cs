Console.WriteLine("Evaluando cadena de carcateres.");
Console.WriteLine("-----------------------------------------");

Console.WriteLine("-----------------------------------------");
Console.WriteLine("Escriba una cadena de caracteres: ");
string Cadena = Console.ReadLine();

Console.WriteLine();

if (Cadena.Length < 25)
{
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine("Escriba (Izquierda o Derecha) para rellenar los espacios con el símbolo '$': ");
    string Lado = Console.ReadLine().ToLower();
    Console.WriteLine("-----------------------------------------");

    Console.WriteLine();

    char pad = '$';
    if (Lado== "izquierda")
    {
        string resultado = Cadena.PadLeft(25, pad);
        Console.WriteLine($"Cadena rellenada a la izquierda: " + resultado);
        Console.WriteLine("--------------------------------------------------------------------------------");

        Console.WriteLine();
    }
    else if (Lado == "derecha")
    {
        string resultado = Cadena.PadRight(25, pad);
        Console.WriteLine($"Cadena rellenada a la derecha: " + resultado);
        Console.WriteLine("--------------------------------------------------------------------------------");

        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Has escrito erroneamente la direccion.");
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("La cadena cumple con los 25 caracteres");
}
