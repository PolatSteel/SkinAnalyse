using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
	public class AIHistory
	{
        [Key]
        public int analyseHistoryId { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        public string analyseResult { get; set; }
        public User User { get; set; }

    }
}
