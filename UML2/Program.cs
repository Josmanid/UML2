
namespace UML2
{
    public class Program
    {
        static void Main(string[] args) {


            // Call the Test method from the Store class again
            Console.WriteLine(" Testing the menu!");
            Store.Test();

            // Display a message to the user to continue with the application
            Console.WriteLine("Hit any key to continue with user dialog");
            Console.ReadKey();

            // Call the Run method of the Store class to start the application
            Store.Run();
            Console.WriteLine("Thanks for you visit at Big Mamma Pizza!");
        }
    }
}
