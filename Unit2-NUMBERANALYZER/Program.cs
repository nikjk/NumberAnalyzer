using System;

string startover = null;
do
{
    string userinput = null;

    Console.WriteLine("Please choose a number between 1 and 100");

    userinput = Console.ReadLine();

    int converteduserinput = int.Parse(userinput);

    if (converteduserinput < 0 || converteduserinput > 100)
    {
        Console.WriteLine("This is not a number between 1 and 100.");
    }

    else if (converteduserinput < 60 && converteduserinput % 2 != 0)
    {
        Console.WriteLine("Odd and less than 60");
    }
    else if (converteduserinput > 2 && converteduserinput < 24 && converteduserinput % 2 == 0)
    {
        Console.WriteLine("Even and less than 25.");
    }
    else if (converteduserinput >= 26 && converteduserinput <= 60 && converteduserinput % 2 == 0)
    {
        Console.WriteLine("Even and between 26 and 60 inclusive.");
    }
    else if (converteduserinput > 60 && converteduserinput % 2 == 0)
    {
        Console.WriteLine("Even and greater than 60.");
    }
    else if (converteduserinput > 60 && converteduserinput % 2 != 0)
    {
        Console.WriteLine("Odd and greater than 60.");
    }
   
    Console.WriteLine("Would you like to go again? Y or N");
    startover = Console.ReadLine();
} while (startover == "y" || startover == "Y");
Console.WriteLine("Goodbye!!");