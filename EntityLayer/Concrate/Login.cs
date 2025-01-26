using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
	public class Login
	{
        [Key]
        public int loginId { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        public User User { get; set; }
        public DateTime loginDate { get; set; }
    }
}
