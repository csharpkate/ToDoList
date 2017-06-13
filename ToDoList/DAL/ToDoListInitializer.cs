using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Models;

namespace ToDoList.DAL
{
    public class ToDoListInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ToDoListContext>
    {
        protected override void Seed(ToDoListContext context)
        {
            var Categories = new List<Category>
            {
                new Category{CategoryName = "Grocery" },
                new Category{CategoryName = "Shopping"},
                new Category{CategoryName = "School"},
                new Category{CategoryName = "Work"},
            };
            Categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var Persons = new List<Person>
            {
                new Person {PersonName = "Ryan", CreateDate = DateTime.Now,},
                new Person {PersonName = "Randy", CreateDate = DateTime.Now,},
                new Person {PersonName = "LJ", CreateDate = DateTime.Now,},
                new Person {PersonName = "Cory", CreateDate = DateTime.Now,},
                new Person {PersonName = "Bruce", CreateDate = DateTime.Now,},
                new Person {PersonName = "Richard", CreateDate = DateTime.Now,}
            };
            var Team = new List<Team>
            {
                new Team{TeamName = "V8", TeamLeadFirstName = "Shelli",TeamLeadLastName="Ringle", CreateDate = DateTime.Now},
                new Team{TeamName = "Bears", TeamLeadFirstName = "Bubba",TeamLeadLastName="Smith", CreateDate = DateTime.Now},
                new Team{TeamName = "Blazers", TeamLeadFirstName = "Larry",TeamLeadLastName="Miller", CreateDate = DateTime.Now},
                new Team{TeamName = "Cubs", TeamLeadFirstName = "Guy",TeamLeadLastName="Lombardi", CreateDate = DateTime.Now},
                new Team{TeamName = "Yankees", TeamLeadFirstName = "Harry",TeamLeadLastName="Carey", CreateDate = DateTime.Now},
            };
        }
    }
}