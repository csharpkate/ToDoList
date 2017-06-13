using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamLeadFirstName { get; set; }
        public string TeamLeadLastName { get; set; }
        public ICollection<Person> Persons { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ? EditDate { get; set; }
        public DateTime ? DeleteDate { get; set; }
    }
}