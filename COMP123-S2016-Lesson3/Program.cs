using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    /*
     * This calss is the driver class 
     */
    public class Program
    {
        /*
         * The main method for the driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person class

            Person harry = new Person();
            harry.Name = "Harry";
            harry.Age = 19;
            harry.SaysHello();
            harry.ShowAge();

            Console.WriteLine();

            Person tom = new Person("Tom");
            tom.Age = 47;
            tom.SaysHello();
            tom.ShowAge();

            Console.WriteLine();

            Person rooney = new Person(30);
            rooney.Name = "Rooney";
            rooney.SaysHello();
            rooney.ShowAge();

            Console.WriteLine();

            Person Marcus = new Person("Marcus", 18);
            Marcus.SaysHello();
            Marcus.ShowAge();

            //Console.WriteLine(person.Name);

            //Console.WriteLine(person.Name);
            //set a value in the Name property of the Person class
            //person.Name = "Tom";

            //get the name value and print to console
            //Console.WriteLine(person.Name);
        }
    }
}
