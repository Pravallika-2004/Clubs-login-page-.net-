using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
       // [Required]
       // [EmailAddress]
       // public string Username { get; set; }

        
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SubscriptionStatus { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public string UserType { get; set; }
        public string Userrole { get; set; }
        public string MobileNumber { get; set; }
        public string WhatsAppNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> IsActiveDate { get; set; }
        public string PhotoPath { get; set; }
    }
}
