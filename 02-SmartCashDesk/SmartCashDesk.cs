
string produs = "Cafea";
int cantitate = 3;
decimal baniPrimiti = 32m;
decimal pretPerBucata = 12.5m;
decimal totalPlata = pretPerBucata * cantitate;


Console.WriteLine($"Produs: {produs}\nCantitate: {cantitate}\n");

if (baniPrimiti >= totalPlata)
{    
    decimal restPlata = baniPrimiti - totalPlata;
    Console.WriteLine($"Aveti bani suficienti!\nTotal: {totalPlata}\t\tRest: {restPlata}");

}
else

{    
    decimal ramasPlata = totalPlata - baniPrimiti;
    Console.WriteLine($"Nu va ajung banii! Trebuie sa mai platiti {ramasPlata}");
}