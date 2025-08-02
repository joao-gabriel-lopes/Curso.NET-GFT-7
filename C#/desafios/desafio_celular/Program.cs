using desafio_celular.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "12345678", modelo: "Tijolão", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "87654321", modelo: "15", imei: "22222222", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Safari");
