namespace DesafioPOO.Models
{
    //implementado
    public class Iphone : Smartphone
    {
         public Iphone(string numero, string modelo, string imei, int memoria)
        {
            
        }
        //omplementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Voce Instalou "+ nomeApp+ " em seu dispositivo Iphone");
        }
       
    }
}