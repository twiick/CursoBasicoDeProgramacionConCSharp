// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int totalJugaror = 0;
int totalDealer = 0;
int num = 0;
int creditos = 0;
int creditosApostados = 0;
bool enElCasino = true;
string mensaje = "";
string switchControl = "menu";
string controlOtraCarta = "";
System.Random random = new System.Random();
Console.WriteLine("Bienvenido al casino");
Console.WriteLine("¿Cuántos creditos deseas?\nRecuerda que necesitas al menos un credito para poder jugar");
creditos = int.Parse(Console.ReadLine()); 
Console.WriteLine($"Se han agregado {creditos} creditos a tu cuenta");
Console.WriteLine($"El casino te informa que tienes {creditos} creditos");
while (enElCasino == true)
{
    totalJugaror = 0;
    totalDealer = 0;
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("Escriba:\n- 21 para jugar al 21\n- Salir para salir del casino");
            switchControl = Console.ReadLine();
            break;
        case "21":
            Console.WriteLine($"¿Cuántos creditos deseas apostar?\n- Recuerda que tienes {creditos} creditos.\n- Recuerda que si ganas obtendrás {creditos * 2} creditos.\n- Recuerda que si piedes, perderás los creditos apostados.");
            creditosApostados = int.Parse(Console.ReadLine());
            Console.WriteLine($"Has apostado {creditosApostados} cretitos.");
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
                Console.Clear();
                mensaje = $"Venciste al Dealer, felicidades ganado {creditosApostados} creditos";
                creditos = creditos + creditosApostados;
            }
            else if (totalJugaror >= 22 || totalJugaror < totalDealer)
            {
                Console.Clear();
                mensaje = $"Perdiste vs el Dealer, has perdido {creditosApostados} creditos";
                creditos = creditos - creditosApostados;
            }
            else
            {
                Console.Clear();
                mensaje = "Condición no valida";
            }
            Console.WriteLine(mensaje);
            switchControl = "menu";
            break;
        case "Salir":
            Console.Clear();
            enElCasino = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Valor ingresado no valido en el casino");
            switchControl = "menu";
            break;
    }
}
Console.WriteLine($"Terminaste con {creditos} creditos");
Console.WriteLine("Gracias por haber jugado en el Casino");