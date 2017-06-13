using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public DateTime DeleteDate { get; set; }



    }
}