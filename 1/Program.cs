using _1;

Auto kek = new Auto(2020, "Focus", "Ford");
Auto zold = new Auto(1992, "Golf", "Wolkswagen");
Auto piros = new Auto(2018, "Fasz", "Habbal");

List<Auto> garazs = new List<Auto>() 
{ 
    kek, 
    zold, 
    piros 
};

foreach (Auto seged in garazs)
{
    seged.KiirAdatok();
}

//atlag szamitas
double atlag = garazs.Average(x => (double)x.GyartasiEv);
Console.WriteLine($"Átlag gyártási év: {atlag}");