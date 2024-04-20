using DesafioPOO.Models;
using System.Globalization;

Iphone i = new Iphone("1399613815", "Iphon9", "154751", 128);
i.ReceberLigacao();
i.Ligar();
i.InstalarAplicativo("Itau");

Nokia n = new Nokia("13996138159", "n9", "2154751", 64);
n.ReceberLigacao();
n.Ligar();
n.InstalarAplicativo("Nubank");