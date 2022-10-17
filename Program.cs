using DesafioPOO.Models;

Console.WriteLine("iPhone");
Iphone Ip = new Iphone("3322-1100", "iPhone 13", "95959595", 6);

Ip.Ligar();
Ip.InstalarAplicativo("WhatsApp");
Ip.ReceberLigacao();
Ip.Infos();

Console.WriteLine("Nokia");
Nokia Nk = new Nokia("8922-4002", "Nokia Tijolo", "123456789", 1);

Nk.Ligar();
Nk.InstalarAplicativo("Cobra");
Nk.ReceberLigacao();
Nk.Infos();