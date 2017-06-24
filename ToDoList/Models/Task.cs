using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{

    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public int CategoryId { get; set; }
        public string Priority { get; set; }

        public int PersonId { get; set; }
        public int ? TeamId { get; set; }
        public DateTime ? StartDate { get; set; }
        public DateTime ? EndDate { get; set; }
        public DateTime ? DueDate { get; set; }
        public bool? InProgress { get; set; }
        public bool? Complete { get; set; }
        public virtual Category Category { get; set; }
        public virtual Person Person { get; set; }
        public virtual Team Team { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<Team> Teams { get; set; }
        public DateTime Created { get; set; }
        public DateTime ? Updated { get; set; }
        public DateTime ? Deleted { get; set; }

    }
}