string produs = "Cafea";
int cantitate = 3;
decimal baniPrimiti = 50m;
decimal pretPerBucata = 12.5m;
decimal totalPlata = pretPerBucata * cantitate;
decimal rest = baniPrimiti - totalPlata;

Console.WriteLine(
    $"Produs: {produs}\nCantitate: {cantitate}\n" +
    $"Total de plata: {totalPlata}\nBani primiti: {baniPrimiti}\n" +
    $"Rest: {rest}\n"
    );