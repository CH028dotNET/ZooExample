using DAL;
using DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ZooContext())
            {
                var zoo = context.Zoos.FirstOrDefault();
                var animals = context.Animals.Where(a => a.ZooId == zoo.Id);

                context.SaveChanges();
            }
        }
    }
}
