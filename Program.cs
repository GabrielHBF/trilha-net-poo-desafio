using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone NOKIA");
Nokia nokia = new Nokia(numero :"545464",modelo :"nokia express",imei:"125aa2",memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Iphone iphone = new Iphone(numero : "22131", modelo : "Iphone 13-pro",imei: "123aa258",memoria : 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");