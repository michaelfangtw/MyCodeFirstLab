using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyCodeFirstLab.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

    

        [DisplayName("Email")]
        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        public bool IsEnable { get; set; }

        [Required]
        public string CreateUser { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }

        
        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        public User()
        {            
            this.Roles = new List<Role>();
        }

        public ICollection<Role> Roles { get; set; }
    }
}