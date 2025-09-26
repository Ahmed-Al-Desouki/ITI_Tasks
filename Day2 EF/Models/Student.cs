using System;
using System.ComponentModel.DataAnnotations;

namespace WinFormsEfCrud.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required] public string FirstName { get; set; } = string.Empty;
        [Required] public string LastName { get; set; } = string.Empty;
        [Required, EmailAddress] public string Email { get; set; } = string.Empty;
        public DateTime EnrollmentDate { get; set; }
    }
}
