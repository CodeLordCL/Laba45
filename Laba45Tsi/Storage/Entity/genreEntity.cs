using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Storage.Entity
{
    public class genreEntity
    {
        [Key]
        [Required]
        [Column("g_id")]
        public Guid id { get; set; }

        [Required]
        [Column("st_genreName")]
        [MaxLength(50)]
        public string genreName { get; set; }
    }
}
