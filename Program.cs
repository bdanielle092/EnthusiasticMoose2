using System;

namespace EnthusiasticMoose2
{
    class Program
    {
     static void Main(string[] args)
{
    // welcomes users
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    //calling the MooseSays method
    // the MooseSays Method on lines 71-100 is use here to talk to the user
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question. This is where we call the question Method
    //Here we ask the questions and then response base on if its true or false from question lines 32-46 and mooseAsk lines 49-68 methods
   Question("Is Canada real? Really?", "It seems very unlikely.", "I  K N E W  I T !!!");
   Question("Are you enthusiastic?", "Yay!", "You should try it!");
   Question("Do you love C# yet?", "Good job sucking up to your instructor!","You will...oh, yes, you will...");
   Question("Do you want to know a secret?","ME TOO!!!! I love secrets...tell me one!","Oh, no...secrets are the best, I love to share them!");

}

//This is where we define the question Method. There are three parameters. 
//line 31-41 is saying fist the moose asks a question, second clears the console, third take the response of yes or no
//this takes us to lines 50-69
 static void Question(string question, string yes, string no)
        {
            bool isTrue = MooseAsks(question);
            if (isTrue)
            {
                Console.Clear();
                MooseSays(yes);
            }
            else
            {
                Console.Clear();
                MooseSays(no);
            }

        }
        // Defining the MooseSays Method
        //here we see the response. If the answer is left blank we ask the question again.
        // if yes we return true and if no we return false. This take us to lines 22-25
static bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

//this is the MooseSays Method. this takes us to lines 16-17. We use string interpolation for message
       static void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}
    }
}

//console is a object
//.ReadLine is a method 
//string is a type
// question is a variable
