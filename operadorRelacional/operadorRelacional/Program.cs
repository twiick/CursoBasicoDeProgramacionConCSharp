﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var (valor1, valor2, valor3) = (10, 2, 1);
Console.WriteLine("Los valores son: " + valor1 + ", " + valor2 + ", " + valor3);

bool resultado1 = valor1 == valor2;
Console.WriteLine("El resultado de la comparación " + valor1 + " == " + valor2 + " es:" + resultado1);

bool resultado2 = valor1 != valor2;
Console.WriteLine("El resultado de la comparación " + valor1 + " != " + valor2 + " es:" + resultado2);

bool resultado3 = valor1 > valor2;
Console.WriteLine("El resultado de la comparación " + valor1 + " > " + valor2 + " es:" + resultado3);

bool resultado4 = valor1 < valor2;
Console.WriteLine("El resultado de la comparación " + valor1 + " < " + valor2 + " es:" + resultado4);

bool resultado5 = valor1 >= valor2;
Console.WriteLine("El resultado de la comparación " + valor1 + " >= " + valor2 + " es:" + resultado5);

bool resultado6 = valor1 <= valor2;
Console.WriteLine("El resultado de la comparación " + valor1 + " <= " + valor2 + " es:" + resultado6);
