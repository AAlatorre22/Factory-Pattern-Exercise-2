using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Database");
            return new List<Product>() {
                new Product() { Name = "Mercedes G-Wagon", Price = 99 },
                new Product() { Name = "Mercedes hat", Price = 100 }
            };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List Database");
        }
    }
}
