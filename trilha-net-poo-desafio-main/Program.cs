using DesafioPOO.Models;

Nokia nokia = new Nokia("13981028934", "A01", "350925378563732", 32);
nokia.InstalarAplicativo("TesteNokia");
nokia.Ligar();

Iphone iphone = new Iphone("13981028934", "M14", "350925378563732", 128);
iphone.InstalarAplicativo("TesteIphone");
iphone.ReceberLigacao();