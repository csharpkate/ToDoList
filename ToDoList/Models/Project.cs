using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectOwnerFirstName { get; set; }
        public string ProjectOwnerLastName { get; set; }
        public int PersonId { get; set; }
        public int TeamId { get; set; }
        public DateTime  ProjectStartDate { get; set; }
        public DateTime ? ProjectDueDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public virtual Person Person { get; set; }
        public virtual Team Team { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}