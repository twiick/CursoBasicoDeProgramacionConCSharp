// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int totalJugaror = 20;
int totalDealer = 15;
string mensaje = "";

if (totalJugaror > totalDealer && totalJugaror < 22)
{
    mensaje = "Venciste al Dealer, felicidades";
}
else if (totalJugaror >= 22 || totalJugaror < totalDealer)
{
    mensaje = "Perdiste vs el Dealer, lo siento";
}
else
{
    mensaje = "Condición no valida";
}

Console.WriteLine(mensaje);