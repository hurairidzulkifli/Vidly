using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Boolean isSubscribed { get; set; }
        public MembershipType MembershipType { get; set; } //Load data from other table
        public byte MembershipTypeId { get; set; }  //foreign key for MembershipType
    }
}