// Lee una cadena de texto
Console.WriteLine("Ingrese una cadena de texto:");
string texto = Console.ReadLine();

// Imprime la cadena en mayúsculas
Console.WriteLine($"Texto en mayúsculas: {texto.ToUpper()}");

// Imprime la cadena en minúsculas
Console.WriteLine($"Texto en minúsculas: {texto.ToLower()}");

// Imprime la cadena al revés
char[] caracteres = texto.ToCharArray();
Array.Reverse(caracteres);
string textoAlReves = new string(caracteres);
Console.WriteLine($"Texto al revés: {textoAlReves}");

// Busca una palabra en la cadena
Console.WriteLine("Ingrese una palabra para buscar en el texto:");
string palabraBuscada = Console.ReadLine();
if (texto.Contains(palabraBuscada))
{
    Console.WriteLine($"La palabra '{palabraBuscada}' fue encontrada en el texto.");
}
else
{
    Console.WriteLine($"La palabra '{palabraBuscada}' no fue encontrada en el texto.");
}

// Cuenta el número de vocales en la cadena
int contadorVocales = 0;
foreach (char caracter in texto.ToLower())
{
    if ("aeiou".Contains(caracter))
    {
        contadorVocales++;
    }
}
Console.WriteLine($"Número de vocales en el texto: {contadorVocales}");
