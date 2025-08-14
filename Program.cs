using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia(numero: "011999995451", modelo: "N95", imei: "00000000000000", memoria: 256); 
nokia.Ligar();
nokia.InstalarAplicativo("WAZE");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone(numero: "011999995451", modelo: "N95", imei: "00000000000000", memoria: 256); 
iphone.Ligar();
iphone.InstalarAplicativo("GOOGLE EARTH");