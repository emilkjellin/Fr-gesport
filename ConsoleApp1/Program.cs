
Console.WriteLine("Hej, vad är det gulligaste djuret i världen");
Console.WriteLine("Capybara, Wilmer eller smurfar");
string name = "sum-"+ "Emil";  
name = name.ToLower();
int sum = 24 + 8;
if(name == "capybara")
{
Console.WriteLine("Got damn right!");
Console.WriteLine("Your score = {sum}!");
Console.WriteLine("vad är det spanska namnet för kyckling");
Console.WriteLine("pollo , poulet eller ዶሮ ");
name = Console.ReadLine();
name = name.ToLower();
if(name == "pollo")
{
Console.WriteLine("Rätt igen!");
Console.WriteLine("Hur många gympass kör Liam per vecka");
Console.WriteLine("6 ,3 eller 5");
name = Console.ReadLine();
name = name.ToLower();
if(name == "6")
{
Console.WriteLine("Du är på en Streak av 3!");
Console.WriteLine("Bra jobbat!");


}
else if(name == "3")
{
Console.WriteLine("FEL, DU VAR SÅ NÄRA");

}
else if(name == "5")
{
Console.WriteLine("HUR LYCKAS DU FÅ FEL PÅ SISTA FRÅGAN");

}
else
{
Console.WriteLine("bra försök buddy");

}

}
else if(name == "poulet")
{
Console.WriteLine("FEL!");

}
else if(name == "ዶሮ")
{
Console.WriteLine("Hur i helsike lyckas du skriva detta! DU VINNER HELT OCH HÅLLET");



}
else
{
Console.WriteLine("SLUTA FÖRSÖKA HITTA BUGGAR!");


}
}
else if(name == "wilmer")
{
Console.WriteLine("Jag fattar vad du menar, men det är fel");

}
else if (name == "smurfar")
{
Console.WriteLine("UHUH,FEL!");


}

else
{
Console.WriteLine("det du precis har sagt är helt orimligt och du borde få fängelsetid");



}
Console.ReadLine();