using System;
using System.Collections.ObjectModel;

namespace DAL.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EnteranceDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ObservableCollection<Book> Books { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }

        public override string ToString()
        {
            string result = this.FirstName + " " + this.LastName;
            return result.ToString();
        }
    }
}