using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone ------------------------------");
Smartphone iphone = new Iphone(numero:"155", modelo: "XR", imei: "11111", memoria: 12);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("\nSmartphone Nokia ------------------------------");
Smartphone nokia = new Nokia(numero:"33", modelo: "Mod 2", imei: "122322", memoria: 24);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");