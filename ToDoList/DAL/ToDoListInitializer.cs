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
                new Person {PersonFirstName = "Ryan", PersonLastName = "Smith",CreateDate = DateTime.Now,},
                new Person {PersonFirstName = "Randy", PersonLastName = "Jones", CreateDate = DateTime.Now,},
                new Person {PersonFirstName = "LJ", PersonLastName = "Miller", CreateDate = DateTime.Now,},
                new Person {PersonFirstName = "Bruce", PersonLastName = "Johnson", CreateDate = DateTime.Now,},
                new Person {PersonFirstName = "Ryan", PersonLastName = "Smith", CreateDate = DateTime.Now,},
                new Person {PersonFirstName = "Ryan", PersonLastName = "Smith", CreateDate = DateTime.Now,}
            };
            var Team = new List<Team>
            {
                new Team{TeamName = "V8", TeamLeadFirstName = "Shelli",TeamLeadLastName="Ringle", CreateDate = DateTime.Now},
                new Team{TeamName = "Bears", TeamLeadFirstName = "Bubba",TeamLeadLastName="Smith", CreateDate = DateTime.Now},
                new Team{TeamName = "Blazers", TeamLeadFirstName = "Larry",TeamLeadLastName="Miller", CreateDate = DateTime.Now},
                new Team{TeamName = "Cubs", TeamLeadFirstName = "Guy",TeamLeadLastName="Lombardi", CreateDate = DateTime.Now},
                new Team{TeamName = "Yankees", TeamLeadFirstName = "Harry",TeamLeadLastName="Carey", CreateDate = DateTime.Now},
            };
            var Project = new List<Project>
            {
                new Project{ProjectName = "CleanUp", PersonId = 1 },
                new Project{ },
                new Project{ }
            };
        }
    }
}