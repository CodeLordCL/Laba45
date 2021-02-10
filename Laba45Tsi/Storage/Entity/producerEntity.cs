using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Storage.Entity
{
    public class producerEntity
    {
        [Key]
        [Required]
        [Column("g_id")]
        public Guid id { get; set; }

        [Required]
        [Column("st_ferstName")]
        [MaxLength(50)]
        public string name { get; set; }
    }
}
