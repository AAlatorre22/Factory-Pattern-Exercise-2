namespace FactoryPatternExercise2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Good day!\nWhat database would you like to use?" +
                "\nPlease enter either:\nL for List\nS for SQL\nM for Mongo");
            string userInput = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(userInput);

            List<Product> products = data.LoadData();
            data.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} is ${product.Price}");
            }

            //data.LoadData(); 
            //data.SaveData();
        }
    }
}
