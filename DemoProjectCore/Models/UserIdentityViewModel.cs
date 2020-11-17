using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DemoProjectCore.Models
{
    public class UserIdentityViewModel
    {
        public int Id { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }
        [Required]
        public string Phone_No { get; set; }
        [Required]
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string  Password{ get; set; }
        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm_Password { get; set; }
    }
}