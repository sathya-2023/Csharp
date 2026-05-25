// You'll use the Random.Next() method to simulate rolling three six-sided dice. You'll evaluate the rolled values to calculate the score. If the score is greater than an arbitrary total, then you'll display a winning message to the user. If the score is below the cutoff, you'll display a losing message to the user.

// If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
// If all three dice you roll result in the same value, you get six bonus points for rolling triples.
// If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.

// Code starts from here
Random dice = new Random();

int dice1 = dice.Next(1,7);
int dice2 = dice.Next(1,7);
int dice3 = dice.Next(1,7);

int total = dice1 + dice2 + dice3;

Console.WriteLine($"You rolled {dice1}, {dice2}, and {dice3} for a total of {total}.");

if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3)
{
    if (dice1 == dice2 && dice2 == dice3)
    {
        total += 6;
        Console.WriteLine("You rolled triples! Bonus 6 points!");
    }
    else
    {
        total += 2;
        Console.WriteLine("You rolled doubles! Bonus 2 points!");
    }
}
if (total >= 16)
{
    Console.WriteLine("You won a Porsche 911 Turbo S!");
}
else if (total >=10 && total < 16)
{
    Console.WriteLine("You won a Tesla Model S Plaid!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip to Netherlands!");
}
else
{
    Console.WriteLine("You won a bicycle!");
}


