using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(
    numero: "123456",
    modelo: "modelo 1",
    imei: "11111111111",
    memoria: 64
);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(
    numero: "987654",
    modelo: "modelo 2",
    imei: "22222222222",
    memoria: 128
);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");