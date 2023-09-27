Console.WriteLine();
string cadena = "MI MAMA ME MIMA, AMO A MI MAMA";
Console.WriteLine("La cadena es: " + cadena);

Console.WriteLine();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Convertir la frase a minusculas");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine();
string Newcadena = cadena.ToLower();
Console.WriteLine("La nueva cadena es: " + Newcadena);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Separacion de la frase");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine();
string[] Scadena = cadena.Split(" ");
Console.WriteLine("La nueva cadena es: ");
Console.WriteLine();
foreach (string s in Scadena)
    Console.WriteLine(s);

Console.WriteLine(); Console.WriteLine();

Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Concatenando la frase con % si es menor que 3");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine();

for (int i = 0; i < Scadena.Length; i++)
{
    if (Scadena[i].Length < 3)
    {
        Scadena[i] += "%";
    }
}
string resultado = string.Join(" ", Scadena);
Console.WriteLine("cadena con %: " + resultado);
    






