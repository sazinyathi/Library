using System;

namespace Library.Models
{
    public class Patron
    {
        public int Id { get; set; }
        public string  Firstname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime  DateOfBirth { get; set; }
        public string TelephoneNumber { get; set; }



    }
}
