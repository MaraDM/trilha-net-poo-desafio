using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone Nokia = new Nokia (numero: "123456",modelo: "Modelo 1",imei: "11111111",memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone Iphone = new Iphone (numero: "456789", modelo: "Modelo 2", imei: "22222222", memoria: 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");