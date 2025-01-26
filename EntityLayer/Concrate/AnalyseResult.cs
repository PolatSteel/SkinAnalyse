using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
	public class AnalyseResult
	{
        [Key]
        public int analyseId { get; set; }
        [ForeignKey("Photo")]
        public int photoId { get; set; }
        public Photo Photo { get; set; }
        public DateTime addedDate { get; set; }
        public string skinIssues { get; set; }
        public string sugestions { get; set; }

    }
}
