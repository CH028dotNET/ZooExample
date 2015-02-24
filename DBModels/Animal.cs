using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ZooId { get; set; }
        [ForeignKey("ZooId")]
        public virtual Zoo Zoo { get; set; }

    }
}
