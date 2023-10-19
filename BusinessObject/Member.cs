using BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }

        [Required]
        [StringLength(40)]
        public string MemberName { get; set; }
        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(40)]
        public string Email { get; set; }
        [Required]
        [StringLength(40)]
        public string City { get; set; }
        [Required]
        [StringLength(40)]
        public string Country { get; set; }
        [Required]
        [StringLength(40)]
        public string Password { get; set; }
    }
}
