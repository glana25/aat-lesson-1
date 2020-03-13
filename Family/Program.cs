
using FamilyStats.Data;
using FamilyStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyStats.Extentions;

namespace FamilyStats
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myName = "Sveta";
            Console.WriteLine(myName.SayHello());

            var zip = "12345";// number that have it . it is the   zip  have the 5 digil.
            Console.WriteLine(zip.CheckZip());

            //foreach (var family in families)
            //{
            //    Console.WriteLine(family);
            //    Console.WriteLine("-------------");
            //}
            var context = new DataContext();
            var myTest = new MyTester(context.Families);
           
            //myTest.Run();

            List<Family> f = myTest.GetFamilyWithNoKids();
            Console.WriteLine("-----GetFamilyWithNoKids-------------");
            PrintFamilies(f);

            f = myTest.GetFamilyWithMostKids();
            Console.WriteLine("----GetFamilyWithMostKids-----");
            PrintFamilies(f);

            f = myTest.GetFamilyByNameTest("jim");
            Console.WriteLine("-----GetFamilyByNameTests---");
            PrintFamilies(f);

            //Console.WriteLine("--------All Father's Names and Ages-----------");
            //foreach (var family in context.Families)
            //{
            //    Console.WriteLine($"{family.Father.Name} - {family.Father.Age}");
            //}

            //f = myTest.FamilyAgeTest();
            Console.WriteLine("--------Average Age of Each Family -----------");
            foreach (var family in context.Families)
            {
                Console.WriteLine(family.FamilyId + " " + family.AveregeAge);
            }


            Console.WriteLine("---- GetYoungestAgeFamily-----");
            var youngestFamily = myTest.GetYoungestAgeFamily();
            Console.WriteLine(youngestFamily.AveregeAge);
            Console.WriteLine(youngestFamily.Age);

            f = myTest.GetFamilyParentNameStartsWith("B");
            Console.WriteLine("---- GetFamilyStartWithLetter-----");
            PrintFamilies(f);

            Console.WriteLine("----GetYoungestChild-----");
            var young= myTest.GetYoungestChild();
            Console.WriteLine(young.YoungestAge);

            Console.WriteLine("--------Get Family With Oldest Child-----------");
            f = myTest.GetOlderChild();
            PrintFamilies(f);
        







            Console.ReadLine();
        }
        public static void PrintFamily(Family family)
        {
            Console.WriteLine(family);
        }
        public static void PrintFamilies(List<Family> families)
        {
            foreach (var family in families)
            {
                PrintFamily(family);
            }
        }
    }

	
    
}
