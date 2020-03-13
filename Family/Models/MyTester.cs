using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyStats.Models
{
    public class MyTester
    {
        private readonly List<Family> _data;

        public MyTester(List<Family> data)
        {
            this._data = data; // this is the privet field.
        }

        public void Run()
        {
            var family = new Family();
            family.Nickname = "jones";
            family.FamilyId = 1;

            Adult father = new Adult();
            //father.FirstName = "Vasily";
            //father.LastName ="Smith";
            father.DateOfBirth = DateTime.Now.AddYears(-34);
            father.Job = "Driver";
            father.LicenseNumber = "1234476";
            //father.DateOfBirth = new DateTime(1987, 1, 1);
            family.Father = father;

            Adult mother = new Adult();
            //mother.FirstName ="Nely";
            //mother.LastName = "Smith";
            mother.DateOfBirth = DateTime.Now.AddYears(-33);
            mother.Job = "Nurse";
            mother.LicenseNumber = "2345677";
            family.Mother = mother;

            Person children = new Person();
            //children.FirstName = "Solomija";
            //children.LastName = "Smith";
            children.DateOfBirth = DateTime.Now.AddYears(-4);
            family.Children.Add(children);

            Person children1 = new Person();
            //children1.FirstName = "Mila";
            //children1.LastName = "Smith";
            children1.DateOfBirth = DateTime.Now.AddYears(-2);
            family.Children.Add(children1);

            Person children2 = new Person();
            //children2.FirstName = "Misha";
            //children2.LastName = "Smith";
            children2.DateOfBirth = DateTime.Now.AddYears(-6);
            family.Children.Add(children2);


            //family.Children = new List<Child>();


            Console.WriteLine(family.ToString());
            //   var person = new Person();


            //var message = person.
            //  message = "Orest is a nice guy";
            //   for (int i = 0; i < 101; i++)
            //   {
            //       message += "!";// concatination
            //   }
            //   Console.ReadLine();


        }

        public List<Family> GetFamilyParentNameStartsWith(string startwithletter)
        {
            List<Family> response = new List<Family>();

            foreach (var family in _data)
            {
                if (family.Father.Name.StartsWith(startwithletter, StringComparison.CurrentCultureIgnoreCase) ||
                    family.Mother.Name.StartsWith(startwithletter, StringComparison.CurrentCultureIgnoreCase))
                {
                    response.Add(family);
                }
            }

            return response;
        }


        public List<Family> GetFamilyWithNoKids()
        {
            List<Family> response = new List<Family>();// initilazing an object responses  on a base of family list so as it's our methods's return type we are ruturning it 
            foreach (var family in _data)// we interate through  _data with will  bring data form our list of family
            {
                if (family.Children.Count == 0)
                {
                    response.Add(family);
                }

            }
            return response;
        }

        //public List<Family> FamilyAgeTest()
        //{
        public Family  GetYoungestChild()
        {
            Family response = null;

            var youngestChildAge = 100;

            foreach (var family in _data)             
            {
                if (family.YoungestAge < youngestChildAge)
                {
                    youngestChildAge = family.YoungestAge;
                    response = family;
                    //response.Add(family);
                }
            }
            return response;
        }

        public List<Family> GetOlderChild()
        {
            List<Family> response = new List<Family>();

            int olderchild = 0;
        
        
            foreach (var family in _data)
            {
                if (family.OlderAge != null && family.OlderAge.Age > olderchild)
                {
                    olderchild = family.OlderAge.Age;
             
                }
            }
            foreach (var family in _data)
            {
                if (family.OlderAge != null && family.OlderAge.Age ==olderchild)
                {
                    response.Add(family);// pick me the family that is the oldest family// means that you need to find //
                }
            }
            return response;

        }


        public List<Family> GetFamilyByNameTest(string nameToFind)
        {

            List<Family> response = new List<Family>();

            foreach (var family in _data)
            {
                if (family.Father.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase)
                    || family.Mother.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase))
                {
                    response.Add(family);
                }
                else
                {
                    foreach (var familyChild in family.Children)
                    {
                        if (familyChild.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase))
                        {
                            response.Add(family);
                            break;
                        }
                    }
                }

            }
            return response;
        }


        public List<Family> GetFamilyWithMostKids()
        {
            List<Family> response = new List<Family>();
            var maxNumberOfKids = 0;
            foreach (var family in _data)
            {
                if (family.Children.Count > maxNumberOfKids)
                {
                    maxNumberOfKids = family.Children.Count;
                }

            }
            foreach (var family in _data)
            {
                if (family.Children.Count == maxNumberOfKids)
                {
                    response.Add(family);
                }
            }
            return response;
        }
        public Family GetYoungestAgeFamily()
        {
            int youngestFamilyAge = 100;
            Family youngestFamily = null;

            foreach (var family in _data)
            {
                if (family.AveregeAge < youngestFamilyAge)
                {
                    youngestFamilyAge = family.AveregeAge;
                    youngestFamily = family;
                }
            }

            return youngestFamily;
        }

           

    }

}
