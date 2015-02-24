using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
    public class ZooCity
    {
        [Key, Column(Order = 0)]
        public int ZooId { get; set; }
        [Key, Column(Order = 1)]
        public int CityId { get; set; }

        [ForeignKey("ZooId")]
        public virtual Zoo Zoo { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}
