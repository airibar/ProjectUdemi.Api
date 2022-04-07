using System;


namespace ProjectUdemi.Api.DomainModels
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }

        public string Email { get; set; }
        public long Movil { get; set; }
        public string ProfileImageUrl { get; set; }
        public Guid GenderId { get; set; }

       
        public Gender Gender { get; set; }
        public Address Address  { get; set; }

        
    }
}
