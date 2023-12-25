using DesafioPOO.Models;

Console.WriteLine("Celular Nokia:");
Smartphone nokia = new Nokia(
    numero: "987654321",
    modelo: "modelo 1",
    imei: "12345",
    memoria: 128
);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone(
    numero: "123456789",
    modelo: "iphone 14",
    imei: "298754",
    memoria: 256
);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine("\nPrograma concluído.");