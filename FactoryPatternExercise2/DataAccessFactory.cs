using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {

        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch(databaseType.ToLower())
            {
                case "list":
                case "l":
                    return new ListDataAccess();
                case "mongo":
                case "m":
                    return new MongoDataAccess();
                case "sql":
                case "s":
                    return new SQLDataAccess();
                default:
                    return new ListDataAccess();

            }


        }


    }
}
