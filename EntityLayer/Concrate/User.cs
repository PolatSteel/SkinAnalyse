using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
	public class User
	{
        [Key]
        public int userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPassWord { get; set; }
        public string userFullName { get; set; }
    }
}
