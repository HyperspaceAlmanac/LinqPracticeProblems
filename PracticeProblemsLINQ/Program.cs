using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> filtered = LinqProblems.RunProblem1(words);

            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            filtered = LinqProblems.RunProblem2(names);

            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Jason", "Ryan"),
                new Customer(4, "Dan", "Laffey")
            };
            Customer loneCustomer = LinqProblems.RunProblem3(customers);
            Customer renamed = LinqProblems.RunProblem4(customers);

            //Problem 5
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65", 
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            double classAverage = LinqProblems.RunProblem5(classGrades);


            //--------------------
            //Bonus Problem 1
            string letters = "terrill";
            string result = LinqProblems.RunBonusProblem1(letters);
            
            //AdditionalTestCases();
        }

        static void AdditionalTestCases()
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "thth", "t", "tenth", "mathematics" };
            List<string> filtered;
            filtered = LinqProblems.RunProblem1(words);
            words = new List<string>() { "the", "bike", "this", "it", "thth", "t", "tenth", "mathematics" };
            filtered = LinqProblems.RunProblem1(words);
            words = new List<string>() { "tt hh", "ht", "abc" };
            filtered = LinqProblems.RunProblem1(words);
            words = new List<string>();
            filtered = LinqProblems.RunProblem1(words);


            //Problem 2
            words = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike", "Nevin", "" };
            filtered = LinqProblems.RunProblem2(words);
            words = new List<string>() { "Mike", "Brad", "Nevin", "Ian"};
            filtered = LinqProblems.RunProblem2(words);
            words = new List<string>();
            filtered = LinqProblems.RunProblem2(words);

            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Jason", "Ryan"),
                new Customer(4, "Dan", "Laffey")
            };
            Customer loneCustomer = LinqProblems.RunProblem3(customers);
            Customer renamed = LinqProblems.RunProblem4(customers);
            new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Ryan", "Jason"),
                new Customer(4, "Dan", "Laffey")
            };
            renamed = LinqProblems.RunProblem4(customers);
            renamed = LinqProblems.RunProblem4(customers);

            //Problem 5
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            double classAverage = LinqProblems.RunProblem5(classGrades);

            classGrades = new List<string>()
            {
                "80,80,92,89,65",
                "93,100,78,84,69",
                "90,90,90,90,90",
                "98,100,66,74,55"
            };
            classAverage = LinqProblems.RunProblem5(classGrades);

            // Improperly formatted number test
            /**
            classGrades = new List<string>()
            {
                "80,80,92,89,65",
                "a,100,78,84,69",
                "90,90,90,90,90",
                "98,100,66,74,55"
            };
            classAverage = LinqProblems.RunProblem5(classGrades);
            **/

            //--------------------
            //Bonus Problem 1
            string letters = "terrill";
            string result = LinqProblems.RunBonusProblem1(letters);
            letters = "AAA";
            result = LinqProblems.RunBonusProblem1(letters);
            letters = "";
            result = LinqProblems.RunBonusProblem1(letters);
            letters = "a";
            result = LinqProblems.RunBonusProblem1(letters);
            letters = "aAa";
            result = LinqProblems.RunBonusProblem1(letters);
            letters = "alchemy";
            result = LinqProblems.RunBonusProblem1(letters);
            letters = "ALCHEMY";
            result = LinqProblems.RunBonusProblem1(letters);
            letters = "HelloFromTheOtherSide";
            result = LinqProblems.RunBonusProblem1(letters);
        }
    }
}
