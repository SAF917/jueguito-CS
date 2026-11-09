Guerrero aquiles = new Guerrero ("Aquiles", 100, 20);
Mago gandalf = new Mago ("gandalf", 100, 20);

Console.WriteLine($"======PRIMERA RONDA====="); 
Console.WriteLine($"Vida de Aquiles: {aquiles.Vida}");
Console.WriteLine($"Vida de Gandalf: {gandalf.Vida}");
Console.WriteLine($"Mana de Gandalf antes de atacar: {gandalf.Mana}");

bool ataquemago = gandalf.Atacar(aquiles);

Console.WriteLine($"luego que atacan a Aquiles: {aquiles.Vida}");
Console.WriteLine($"Mana de Gandalf despues de atacar: {gandalf.Mana}");
Console.WriteLine($"======Primera ronda TERMINADA====="); 
Console.WriteLine($"======SEGUNDA RONDA====="); 

Console.WriteLine($"Aquiles ataca:  "); 

bool ataqueAquiles = aquiles.Atacar(gandalf);

Console.WriteLine($"Vida de Gandalf despues del ataque: {gandalf.Vida}");
Console.WriteLine($"=====SEGUNDA RONDA TRMINADA====== "); 
Console.WriteLine($"=====TERCERA RONDA=====");
Console.WriteLine($"Ataque del Mago:  ");

bool ataquegandalf = gandalf.Atacar(aquiles);

Console.WriteLine($"luego que atacan a Aquiles: {aquiles.Vida}");
Console.WriteLine($"Mana de Gandalf despues de atacar: {gandalf.Mana}");
Console.WriteLine($"======TERCERA ronda TERMINADA====="); 



