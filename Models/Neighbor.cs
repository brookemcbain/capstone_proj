using Capstone.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone
{
    public class Neighbor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name:")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }
        [Display(Name = "Email Address:")]
        public string EmailAddress { get; set; }
        [Display(Name = "Phone Number:")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Home Address:")]
        public string HomeAddress { get; set; }
        [Display(Name = "City:")]
        public string City { get; set; }
        [Display(Name = "State:")]
        public string State { get; set; }
        [Display(Name = "Zip Code:")]
        public string ZipCode { get; set; }
        [Display(Name = "Which Milwaukee Community Are You A Part Of? ")]
        public string Community { get; set; }


        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [ForeignKey("SpotID")]
        [Display(Name = "Location")]
        public int? SpotID { get; set; }
        public Location Location { get; set; }
        
        [ForeignKey("Post")]
        public int? PostId { get; set; }
        public Post PostMessage { get; set; }
    }
}
