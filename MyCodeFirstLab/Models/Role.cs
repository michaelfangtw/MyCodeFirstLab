using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeFirstLab.Models
{
    public class Role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        [Key]
        [Required]
        public int ID { get; set; }
 
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
         
        
        [Required]
        public string CreateUser { get; set; }

        [DisplayName("建立時間")]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }

        [DisplayName("更新者")]
        public string UpdateUser { get; set; }

        [DisplayName("更新時間")]
        public DateTime? UpdateDate { get; set; }

        public Role()
        {         
            this.Users = new List<User>();
        }

        public ICollection<User> Users { get; set; }

    }
}
