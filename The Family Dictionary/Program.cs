using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Family_Dictionary
{
    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                { "name", "Krista"},
                { "age", "42"}
            });

            myFamily.Add("Husband", new Dictionary<string, string>() {

                {"name", "Amit Kumar" },
                {"age", "40" }

            });

            myFamily.Add("daughter", new Dictionary<string, string>()
            {

                {"name", "Shreeti Amit" },
                {"age", "13" }
            });



            //var qry = from outer in allOffset
            //from inner in outer.Value
            //select new { OuterKey = outer.Key, InnerKey = inner.Key, inner.Value };
            /*
            var nestedDictionary = from outer in myFamily
                                   from inner in outer.Value
                                   select new { OuterKey = outer.Key, InnerKey = inner.Key, InnerValue = inner.Value };
            foreach (var nest in nestedDictionary)
            {
               // Console.WriteLine(nest.OuterKey);
               // Console.WriteLine(nest.InnerKey);
               //Console.WriteLine(nest.InnerValue);
                Console.WriteLine($"{nest.OuterKey}" + ", " + $"{nest.InnerKey}" + ", " + $"{nest.InnerValue}");
            }
            */
            
            foreach (KeyValuePair<string, Dictionary<string, string>> nest in myFamily)
            {
                Console.WriteLine($"{nest.Value["name"]} is my {nest.Key} and is {nest.Value["age"]} years old");
            }

            Console.ReadKey();
        }
    }
}
