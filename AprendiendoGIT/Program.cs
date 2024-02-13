// Calcula la suma de dos números enteros
int num1 = 10;                       /*El $ es para hacer una cadena es interpolada. Las expresiones entre */
int num2 = 5;                        /*llaves {} son evaluadas y su resultado se inserta en la cadena :) */
int suma = num1 + num2;
Console.WriteLine($"La Suma de {num1} y {num2} es: {suma}");

// Calcula la resta de dos números decimales
decimal decimal1 = 10.5m;
decimal decimal2 = 3.2m;
decimal resta = decimal1 - decimal2;
Console.WriteLine($"La Resta de {decimal1} y {decimal2} es: {resta}");

// Calcula la multiplicación de dos números flotantes
float float1 = 3.5f;
float float2 = 2.5f;
float multiplicacion = float1 * float2;
Console.WriteLine($"La Multiplicación de {float1} y {float2} es: {multiplicacion}");

// Calcula la división de dos números enteros
int dividendo = 20;
int divisor = 3;
int division = dividendo / divisor;
Console.WriteLine($"La División de {dividendo} entre {divisor} es: {division}");

// Calcula el módulo de dos números enteros
int numero1 = 20;
int numero2 = 7;
int modulo = numero1 % numero2;
Console.WriteLine($"El Módulo de {numero1} entre {numero2} es: {modulo}");
