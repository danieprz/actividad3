// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, este es un programa el cual puede hacer operaciones con dos números.");
Console.WriteLine("Introduce un número");
var primernumero=Console.ReadLine();
int num1 = int.Parse(primernumero);
Console.WriteLine("Introduce otro número");
var segundonumero=Console.ReadLine();
int num2 = int.Parse(segundonumero);
var suma = num1 + num2;
Console.WriteLine("La suma de " + primernumero + " + " + segundonumero + " es:" + suma);
var resta = num1 - num2;
Console.WriteLine("La resta de " + primernumero + " - " + segundonumero + " es:" + resta);
var producto = num1 * num2;
Console.WriteLine("El producto de " + primernumero + " * " + segundonumero + " es:" + producto);
var division = num1 / num2;
Console.WriteLine("El cociente de " + primernumero + " / " + segundonumero + " es:" + division);