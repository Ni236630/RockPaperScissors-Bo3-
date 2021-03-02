using System;

int PlayerScore = 0;
int CompScore = 0;

Main();


void Main()
{
    Console.WriteLine("Welcome to Rock, Paper, Scissors! (Bo3)");
    Console.WriteLine("---------------------------");
    Console.WriteLine("| Player: 0 | Computer: 0 |");
    Console.WriteLine("---------------------------");
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");
    Console.WriteLine("4) Exit Game");

    
        Choice();

        //win conditions for game
        if (PlayerScore == 3)
        {
           
            Console.WriteLine("You Won!");
        }
        else if ( CompScore == 3)
        {
            
            Console.WriteLine("You Lost!");
        }
      
}



void Choice()
{
    int Choice = Int32.Parse(Console.ReadLine());
    int CompChoice = new Random().Next(1,4);

    // to make sure score is recorded for the initial pick 

    Score(Choice, CompChoice);
    RockPaperScissors(Choice, CompChoice);
    
    
    while ( PlayerScore != 3 || Choice != 4)
    {
        if( Choice > 0 && Choice < 4)
        {
            Score(Choice, CompChoice);
            RockPaperScissors(Choice, CompChoice);
            Choice = Int32.Parse(Console.ReadLine());
            CompChoice = new Random().Next(1,4);

        }
        else if ( Choice == 4)
        {
            Console.WriteLine("Goodbye");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("That wasn't an option.");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
            Console.WriteLine("4) Exit Game"); 

            Choice = Int32.Parse(Console.ReadLine());
            

        }
        
    }
    

}

void Score(int Player, int Cpu)
{
    
    Console.WriteLine("---------------------------");
    Console.WriteLine($"| Player: {PlayerScore} | Computer: {CompScore} |");
    Console.WriteLine("---------------------------");
    Console.WriteLine("What would you like to throw now?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");
    Console.WriteLine("4) Exit Game");


    if ( Cpu == 1 && Player == 3 || Cpu > Player)
    {
        CompScore++;
    } 
    else 
    {
        PlayerScore++;
    }
}

void RockPaperScissors( int Player, int Cpu)
{


    switch(Player)
    {
        case 1 :
         Rock();
         break;
        case 2 :
         Paper();
         break;
        case 3 :
         Scissors();
         break;
    }

    Console.WriteLine("VS");

    switch(Cpu)
    {
        case 1 :
         Rock();
         break;
        case 2 :
         Paper();
         break;
        case 3 :
         Scissors();
         break;
    }

    
}

void Rock()
{
    Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
}

void Paper()
{
    Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
");
}

void Scissors()
{
    Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
");
}