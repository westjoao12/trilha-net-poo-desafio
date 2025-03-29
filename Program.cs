using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("::::: INICIALIZANDO OS TESTES ::::");
Console.WriteLine("\n");
Console.WriteLine("::::: Testando a classe Nokia ::::");
var nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "1111222321", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");

Console.WriteLine("::::: Testando a classe Iphone ::::");

var iphone = new Iphone(numero: "123456", modelo: "Iphone 13",imei: "1111222333", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
