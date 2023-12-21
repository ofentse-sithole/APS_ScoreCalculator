internal class Program
{
    private static void Main(string[] args)
    {
        //initalizing variables
        string welcomeMessage = "Welcome to the APS Score Calculator!";
        string name, surname;
        int length;

        Console.WriteLine(welcomeMessage);

        Console.WriteLine("Please enter your name: ");
        name = Console.ReadLine();

        Console.WriteLine("Please enter your surname: ");
        surname = Console.ReadLine();

        Console.WriteLine("Hello, " + name + " " + surname + "!" + "\n"
                            + "we are here to assist you calculate your total aps score which will help you know what you qualify for.");

        
        //if statement for aps score calcultor for qualify check
        if(APS_Calculator() <= 15)
        {
            Console.WriteLine("You qualify for a higher certificate");
        }
        else if(Convert.ToInt32(APS_Calculator()) >= 15 && APS_Calculator() <=23)
        {
            Console.WriteLine("You qualify for a diploma");
        }
        else if(APS_Calculator() >= 23)
        {
            Console.WriteLine("You qualify for a degree");
        }
        else
        {
            Console.WriteLine("You do not qualify for any of the above! "+ "\n" + "Try Upgrading and hopefully all goes well");
        }
        

        //Subject method call
        Subject();
    }

    //This method assist user to calculate their APS score
    private static int APS_Calculator()
    {
        int length = 6;
        int total = 0;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Please enter your subject admission score point: " + i);

            // Read user input as an integer
            int score = Convert.ToInt32(Console.ReadLine());

            // Add the entered score to the total
            total += score;
        }

        return total;
    }


    //This method assist user to add their subjects as well as give them a desire job on what to study after high school
    private static void Subject()
    {
        string[] subject = new string[6];

        for (int i = 0; i < subject.Length; i++)
        {
            Console.WriteLine("Please enter your subject name: " + i);
            subject[i] = Console.ReadLine();
        }

        if (subject[0] == "Mathematics" && subject[1] == "Physical Science" && subject[2] == "Life Science" || subject[3] == "Geography" || subject[4] == "History" || subject[5] == "Business Studies")
        {
            Console.WriteLine("You qualify to study Medicine");
        }

        else if (subject[0] == "Mathematics" || subject[1] == "Physical Science" || subject[2] == "Life Science" || subject[3] == "Geography" && subject[4] == "History" || subject[5] == "Accounting")
        {
            Console.WriteLine("You qualify to study Accounting");
        }

        else if (subject[0] == "Mathematics" && subject[1] == "Physical Science" || subject[2] == "Life Science" || subject[3] == "Geography" || subject[4] == "History" || subject[5] == "Economics")
        {
            Console.WriteLine("You qualify to study Economics");
        }

        else if (subject[0] == "Mathematics" && subject[1] == "Physical Science" || subject[2] == "Life Science" || subject[3] == "Geography" || subject[4] == "History" || subject[5] == "Mathematical Literacy")
        {
            Console.WriteLine("You qualify to study Law");
        }

        else if (subject[0] == "Mathematics" && subject[1] == "Physical Science" && subject[2] == "Life Science" || subject[3] == "Geography" || subject[4] == "History" || subject[5] == "Consumer Studies")
        {
            Console.WriteLine("You qualify to study Consumer Studies");
        }

        else if (subject[0] == "Mathematics" && subject[1] == "Physical Science" && subject[2] == "Life Science" && subject[3] == "Geography" && subject[4] == "History" && subject[5] == "Agricultural Sciences")
        {
            Console.WriteLine("You qualify to study Agricultural Sciences");
        }

        else if (subject[0] == "Mathematics" || subject[1] == "Physical Science" && subject[2] == "Information Technology")
        {
            Console.WriteLine("You qualify to study Information Technology");
        }
    }
}