using _1;

Auto kek = new Auto(2020, "Focus", "Ford");
Auto zold = new Auto(3100, "Golf", "Wolkswagen");
Auto piros = new Auto(2017, "Dacia", "Lodgy");

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