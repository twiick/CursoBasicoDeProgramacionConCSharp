// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hola, esto es un mensaje de consola");
// Programa que calcula el área de un rectángulo
double ladoA;
double ladoB;
double area;
Console.WriteLine("Calcula el área de un rectángulo");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());
area = ladoA * ladoB;
Console.WriteLine("Lado A: " + ladoA);
Console.WriteLine("Lado B: " + ladoB);
Console.WriteLine("El resultado del área es: " + area);