using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Database");
            return new List<Product>() {
                new Product() { Name = "Blink-182 disc", Price = 19 },
                new Product() { Name = "Baby grand piano", Price = 1000}
            };
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo Database");

        }
    }
}
