using System;

// function for the magic to happen...
MagicMoose();

void MagicMoose()
{
    Console.WriteLine("Hello, I'm the Magical 8 Moose, what would you like to know?");

    // user asks a question for the moose to randomly generate an answer.
    string Questions = Console.ReadLine();

    // If statement declared if user doesnt wish to ask question.
    if (string.IsNullOrEmpty(Questions))
    {
        MooseSays("Silence is a virtue, but will not lead to your future!");
    }
    else
    {
        MooseSays(MagicAnswer());
    }
}

// We need a function for the answer to life's questions
string MagicAnswer()
{
    // Random number generator
    Random Number = new Random();
    int RandomNumber = Number.Next(0, 19);
    string Fortune = "";

    // Switch statements that will yeild or random numbered answer
    switch (RandomNumber)
    {
        case 0:
            Fortune = "As I see it, yes.";
            break;
        case 1:
            Fortune = "Ask again later.";
            break;
        case 2:
            Fortune = "Better not tell you now.";
            break;
        case 3:
            Fortune = "Cannot predict now.";
            break;
        case 4:
            Fortune = "Concentrate and ask again.";
            break;
        case 5:
            Fortune = "Don't count on it.";
            break;
        case 6:
            Fortune = "It is decidely so.";
            break;
        case 7:
            Fortune = "It is certain.";
            break;
        case 8:
            Fortune = "Most likely.";
            break;
        case 9:
            Fortune = "My reply is no.";
            break;
        case 10:
            Fortune = "My sources say no.";
            break;
        case 11:
            Fortune = "Outlook not so good.";
            break;
        case 12:
            Fortune = "Outlook good.";
            break;
        case 13:
            Fortune = "Reply hazy, try agin.";
            break;
        case 14:
            Fortune = "All signs point to yes.";
            break;
        case 15:
            Fortune = "Very doubtful.";
            break;
        case 16:
            Fortune = "Without a doubt.";
            break;
        case 17:
            Fortune = "Yes.";
            break;
        case 18:
            Fortune = "Yes - definitely!";
            break;
        case 19:
            Fortune = "You may rely on it.";
            break;
        case 20:
            Fortune = "Silence is a virtue, but will not lead to your future!";
            break;
    }
    return Fortune;
}


void MooseSays(string Fortune)
{
    // '@' is used to indicate multi line string.
    // '$" used for interpolation
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
                       |   / \   |    {Fortune}
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



// Main();
// void Main()
// {
//     Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine();

//     // Giving the moose words
//     MooseSays("H I, I'M  E N T H U S I A S T I C !");
//     MooseSays("I really am enthusiastic");

//     // Ask a Moose a question 
//     // Simplify how we ask questions. Functions that will ask the questions with out repeating the moose everytime. 
//     // MooseAsks the question. User answers
//     MooseQuestions("Are you enthusiastic?", "Yay!", "You should try it!");
//     MooseQuestions("Is Canada real?", "That doesn't seem right.", "I knew it!");
//     MooseQuestions("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
//     MooseQuestions("Do you want to know a secret?", "ME TOO!!!! I love secrets..tell me one!", "Oh, no...secrets are the best, I love to sharethem!");
// }

// // Moose questions. Function that will determine the response for the CLI.
// // Simplifying the commands
// void MooseQuestions(string question, string yes, string no)
// {
//     {
//         bool isTrue = MooseAsks(question);
//         if (isTrue)
//         {
//             MooseSays(yes);
//         }
//         else
//         {
//             MooseSays(no);
//         }
//     }
// }
// bool MooseAsks(string question)
// {
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower();

//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }

//     if (answer == "y")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }