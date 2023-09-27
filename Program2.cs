using System;

Console.WriteLine("Comparaciones de cadenas.");
Console.WriteLine("-----------------------------------------");
Console.WriteLine();

Console.WriteLine("Ingrese una cadena de caracteres: ");
string cadena1 = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Ingrese otra cadena de caracteres: ");
string cadena2 = Console.ReadLine();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-----------------------------------------");
Console.WriteLine("Por el metodo de compareTo");
Console.WriteLine("-----------------------------------------");

int comparacion = cadena1.CompareTo(cadena2);

if  (comparacion == 0)
{
    Console.WriteLine("Las cadenas son iguales.");
    Console.WriteLine();

}
else
{
    Console.WriteLine("Las cadenas no son iguales.");
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-----------------------------------------");
Console.WriteLine("Por el metodo de Equals");
Console.WriteLine("-----------------------------------------");

if (cadena1.Equals(cadena2) == false)
{
    Console.WriteLine("Las cadenas no son iguales.");
}
else
{
    Console.WriteLine("Las cadenas son iguales.");
}