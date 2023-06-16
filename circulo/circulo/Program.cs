// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var radio = 0d;
var resultado = 0d;

Console.WriteLine("Bienvenido a la calculadora del área del circulo");
Console.WriteLine("Ingresal el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());
resultado = Math.PI * Math.Pow(radio, 2);
Console.WriteLine("El área del circulo es: " + resultado);