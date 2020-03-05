using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string question, response;

            Console.WriteLine("Choose 1 of the following," 
                + "please type exactly as it is displayed:"
                + "\nFun fact\nDad joke\n2 sentence horror\nTongue twister\n" 
                + "Type EXIT to leave");
            question = Console.ReadLine();

            // Switch case to reply to player inputs
            switch (question)
            {
                case "Fun fact":
                    response = "Banging your head against a wall for " 
                        + "one hour burns 150 calories.";
                    break;
                case "Dad joke":
                    response = "Did you hear about the chameleon who " 
                        + "couldn't change color? He had a reptile dysfunction.";
                    break;
                case "2 sentence horror":
                    response = "The doctors told the amputee he might " 
                        + "experience a phantom limb from time to time. " 
                        + "Nobody prepared him for the moments though, when " 
                        + "he felt cold fingers brush across his phantom hand.";
                    break;
                case "Tongue twister":
                    response = "I scream, you scream, we all scream " 
                        + "for ice cream";
                    break;
                case "EXIT":
                    return;
                default:
                    return;
            }

            // Displays answer accordingly
            Console.WriteLine(response);
        }
    }
}
