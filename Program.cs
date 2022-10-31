namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            Introduction.GenerateIntroductoryText();

            MenuOptions.printMenuOptions();

            ListOfCardHolders cardHolders = new ListOfCardHolders();

            cardHolders.createUserList();

            List<cardHolder> testList = new List<cardHolder>();

            testList.Add(new cardHolder("023456780", 1234, "John", "Doe", 99.99));

            Console.WriteLine("Welcome to WizATM");
            Console.WriteLine("Please insert your debit card: ");
            string debitCardNum = "";
            cardHolder currentUser; // Initialised but not = to anythin yet

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    // Check against our db (List)
                    currentUser = testList.FirstOrDefault(a => a.cardNum == debitCardNum);
                    if (currentUser != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card not recognised. Please try again.");
                    }
                }
                catch
                {
                    Console.WriteLine("Card not recognised. Please try again.");
                }
            }

            Console.WriteLine("Please enter your pin: ");
            int userPin = 0;

            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.Pin == userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card not recognised. Please try again.");
                    }
                }
                catch
                {
                    Console.WriteLine("Card not recognised. Please try again.");
                }
            }

            Console.WriteLine("Welcome " + currentUser.FirstName + " :)");
            int option = 0;

            do
            {
                MenuOptions.printMenuOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1)
                {
                    Transactions.deposit(currentUser);
                }
                if (option == 2)
                {
                    Transactions.withdraw(currentUser);
                }
                if (option == 3)
                {
                    Transactions.currentBalance(currentUser);
                }
                else if(option == 4)
                {
                    break;
                }
                else
                {
                    option = 0;
                }
            } while (option != 4);
            Console.WriteLine("Thank you for using WizATM! Have a nice day! :) ");

        }
    }
}