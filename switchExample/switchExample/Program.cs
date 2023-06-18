// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int totalJugaror = 0;
int totalDealer = 0;
string mensaje = "";
int num = 0;
string switchControl="menu";
string controlOtraCarta = "";

System.Random random = new System.Random();
while (true)
{
    totalJugaror = 0;
    totalDealer = 0;
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("Bienvenido al casino");
            Console.WriteLine("Escriba 21 para jugar al 21");
            switchControl = Console.ReadLine();
            break;
        case "21":
            do
            {
                num = random.Next(1, 12);
                totalJugaror = totalJugaror + num;
                Console.WriteLine("Toma tu carta");
                Console.WriteLine($"Te salio el: {num}");
                Console.WriteLine("¿Deseas otra carta?");
                controlOtraCarta = Console.ReadLine();
            } while (controlOtraCarta == "Si" || controlOtraCarta == "si" || controlOtraCarta == "Yes" || controlOtraCarta == "yes");

            totalDealer = random.Next(12, 23);
            Console.WriteLine($"El dealer tiene: {totalDealer}");
            
            if (totalJugaror > totalDealer && totalJugaror <= 21 || totalDealer > 21)
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
            switchControl = "menu";
            break;
        default:
            Console.WriteLine("Valor ingresado no valido en el casino");
            break;
    }
}
