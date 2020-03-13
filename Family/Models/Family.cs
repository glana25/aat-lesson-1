using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyStats.Models
{
    public class Family
    {

        public Family()
        {
            Children = new List<Person>();
        }
        public int FamilyId { get; set; }
        public string Nickname { get; set; }
        public Adult Father { get; set; }

        public Adult Mother { get; set; }
        public Adult Age { get; set; }

       

        public List<Person> Children { get; set; }

        public int AveregeAge
        {
            get 
            { 
                var age = Father.Age + Mother.Age;
                foreach (var child in Children)
                {
                    age += child.Age;
                }
                return age / (2 + Children.Count);
            
            }
            
        }

        public int YoungestAge
        {
            get
            {
                var younageage = 100;
                foreach (var Child in Children)
                {
                    if (Child.Age < younageage)
                    {
                        younageage = Child.Age;
                    }

                }
                return younageage;
            }
        }
        public Person OlderAge
        {
            get
            {
                if (this.Children.Count ==0)
                {
                    return  null;
                }
              Person   olderage = Children[0];
                foreach (var Child in Children)
                {
                    if (Child.Age > olderage.Age)
                    {
                        olderage = Child;
                    }
                   
                }
                return olderage;
                
            }
        }


        public override string ToString()
        {
            Console.WriteLine("Family" + Nickname + " )");

            var sepataror = "    ";//make you 4 space 
            var buildder = new StringBuilder();
            buildder.AppendLine($"Family {Nickname}({FamilyId}");
            buildder.AppendLine($" {sepataror}Parent");
            buildder.AppendLine($"{sepataror}{sepataror}{Father.Name}-{DateTime.Now.Year - Father.DateOfBirth.Year},{Father.Job},{Father.LicenseNumber}");
            buildder.AppendLine($"{sepataror}{sepataror}{Mother.Name}-{DateTime.Now.Year - Mother.DateOfBirth.Year},{Mother.Job},{Mother.LicenseNumber}");
            buildder.AppendLine($"{sepataror}Kids");
            foreach (var child in Children)
            {
                buildder.AppendLine($"{sepataror}{sepataror}{child.Name}-{DateTime.Now.Year - child.DateOfBirth.Year}");
            }
            return buildder.ToString();
        }
    }
}


