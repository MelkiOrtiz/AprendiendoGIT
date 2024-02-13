//Conversion de entero a decimal
int entero = 5;
decimal decimalConvertido = Convert.ToDecimal(entero);
Console.WriteLine("El Entero Convertido A Decimal: " + decimalConvertido);

// Conversión de decimal a flotante
decimal decimalOriginal = 10.5m;
float floatConvertido = Convert.ToSingle(decimalOriginal);
Console.WriteLine($"Decimal convertido a flotante: " + floatConvertido);

// Conversión de flotante a entero
float flotanteOriginal = 10.8f;
int enteroConvertido = Convert.ToInt32(flotanteOriginal);
Console.WriteLine($"Flotante convertido a entero: " + enteroConvertido);

// Conversión de caracter a entero                                              
char caracterOriginal = 'A';                                                    /* Se Hace la conversión del carácter a su valor*/
int caracterConvertido = (int)caracterOriginal;                                 /* entero ASCII correspondiente. */
Console.WriteLine($"Carácter convertido a entero: " + caracterConvertido);

// Conversión de entero a caracter
int enteroCaracter = 65;                                                        
char caracterResultado = (char)enteroCaracter;                                  // Aca lo mismo pero alrevez 
Console.WriteLine($"Entero convertido a carácter: {caracterResultado}");