// Calcula el área de un triángulo
double baseTriangulo = 5;
double alturaTriangulo = 7;
double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
Console.WriteLine($"El área del triángulo es: {areaTriangulo}");

// Calcula el volumen de una esfera
double radioEsfera = 4;
double volumenEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);
Console.WriteLine($"El volumen de la esfera es: {volumenEsfera}");

// Calcula la distancia entre dos puntos
double x1 = 2, y1 = 3;
double x2 = 5, y2 = 7;
double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"La distancia entre los dos puntos es: {distancia}");

// Calcula la temperatura en grados Fahrenheit a partir de la temperatura en grados Celsius
double temperaturaCelsius = 25;               // Podes cambiar la temperatura en grados Celsius si quieres
double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;
Console.WriteLine($"La temperatura en grados Fahrenheit es: {temperaturaFahrenheit}");

// Calcula la temperatura en grados Celsius a partir de la temperatura en grados Fahrenheit
temperaturaFahrenheit = 77;                   // Aca tambien se puede cambiar la temperatura, la formula no cambia
temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;   //Esta formula y la anterior no se pueden cambiar porque asi es la formula
Console.WriteLine($"La temperatura en grados Celsius es: {temperaturaCelsius}");
