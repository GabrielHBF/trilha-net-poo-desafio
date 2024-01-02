namespace DesafioPOO.Models
{
    // implementado
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
        {

        }
        // implemetado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Voce Instalou "+ nomeApp+ " em seu dispositivo Nokia");
        }
    }
}