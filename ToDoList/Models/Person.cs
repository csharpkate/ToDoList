using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Person : IPerson
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ? EditDate { get; set; }
        public DateTime ? DeleteDate { get; set; }
    }
}