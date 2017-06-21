using System;

namespace ToDoList.Models
{
    public interface IPerson
    {
        DateTime CreateDate { get; set; }
        DateTime? DeleteDate { get; set; }
        DateTime? EditDate { get; set; }
        int PersonId { get; set; }
        string PersonFirstName { get; set; }
        string PersonLastName { get; set; }
    }
}