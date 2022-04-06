using System;
using felip.Desktop.Sayuri.DIORPGDESAFIO;

{
   Knight Arus =  new Knight("Arus", 42, "Knight", "HP 469 / 749", "MP 72 / 72");
   Ninja Wedge =  new Ninja("Wedge", 42, "Ninja", "HP 292 / 574", "MP 89 / 89");
   WhiteWizard Jenica =  new WhiteWizard("Jenica", 42, "White Wizard", "HP 325 / 601", "MP 474 / 482");
   BlackWizard Topapa =  new BlackWizard("Topapa", 42, "Black Wizard", "HP 106 / 385", "MP 611 / 641");
   
   Console.WriteLine(Arus.Attack());
   Console.WriteLine(Wedge.Attack());
   Console.WriteLine(Jenica.Attack(1));
   Console.WriteLine(Jenica.Attack(7));  
   Console.WriteLine(Topapa.Attack(1));
   Console.WriteLine(Topapa.Attack(8));  
}

