
Console.WriteLine("Hey, what is the cutest animal on the planet?");
Console.WriteLine("Capybara{z}, Wilmer{x} or smurfar{c}");
string name = Console.ReadLine();  
name = name.ToLower();
int points = 0;
if(name == "z")
{
points++;
Console.WriteLine("Got damn right!");
Console.WriteLine($"You have {points} point");
Console.WriteLine("What is the spannish word for chicken?");
Console.WriteLine("pollo{z} , poulet{x} or ዶሮ ");
name = Console.ReadLine();
name = name.ToLower();
if(name == "z")
{
points++;
Console.WriteLine("Right again!");
Console.WriteLine($"You have {points} points");
Console.WriteLine("Which company is dominating in F1 racing");
Console.WriteLine("Redbull{y}, Ferarri{x}, lamborghini{c} ");
name = Console.ReadLine();
name = name.ToLower();
if(name == "y")
{
Console.WriteLine("You are on a streak of 2 right answers!");
Console.WriteLine("Keep it up!");


}
else if(name == "x")
{
Console.WriteLine("wrong, but ferrari do race in F1");

}
else if(name == "c")
{
Console.WriteLine("How do you choose the only company that is not competing in F1:(");

}
else
{
Console.WriteLine("good try budddy");

}

}
else if(name == "x")
{
Console.WriteLine("Wrong!");

}
else if(name == "ዶሮ")
{
Console.WriteLine("YOU WIN, YOU ARE CRAZY I DID NOT EXPECT SOMEONE TO GET THIS BUT FOR YOU WHO DID I AM GREATFUL THAT YOU COMPLETED MY GAME IN THE BEST WAY POSSIBLE!");



}
else
{
Console.WriteLine("STOP TRYING TO ESCAPE THE QUESTION!");


}
}
else if(name == "x")
{
Console.WriteLine("SO SO So SO SO WRONG!");

}
else if (name == "c")
{
Console.WriteLine("UHUH,WRONG!");


}

else
{
Console.WriteLine("bad boy!!! you are crazy!!");



}
Console.ReadLine();