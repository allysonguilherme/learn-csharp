/*Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"{roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("you have triples! +6 bonus to total!");
    total += 6;
}else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    Console.WriteLine("you have doubles! +2 bonus to total!");
    total += 2;
}

if (total >= 15)
{
    Console.WriteLine("You win a new a airplane!");
}else if(total >= 10)
    Console.WriteLine("You win a  boat!");
else if(total == 7)
    Console.WriteLine("You win a gift-card!");
else
    Console.WriteLine("You win a kitten");*/

using System.Collections.ObjectModel;
using IfStatements;

var subscriptions = new Collection<Subscription>()
{
    new()
    {
        Days = [10, 9, 8, 7, 6],
        Message = "your subscriptions will expire soon.  Renew now!"
    },
    new()
    {
        Days = [5, 4, 3, 2],
        Message = $"Your subscription expires in <placeholder> days. \nRenew now and save 10%!"
    },
    new()
    {
        Days = [1],
        Message = "Your subscriptions expires within a day!\nRenew now and save 20%"
    },
    new()
    {
        Days = [0],
        Message = "Your subscription has expired."
    }
};
    
Random dice = new Random();
var daysUntilExpiration = dice.Next(12);

var subscriptionCase = subscriptions.FirstOrDefault(s => s.Days.Contains(daysUntilExpiration));

if(subscriptionCase is not null)
    Console.WriteLine(subscriptionCase.Message.Replace("<placeholder>", daysUntilExpiration.ToString()));


    
    