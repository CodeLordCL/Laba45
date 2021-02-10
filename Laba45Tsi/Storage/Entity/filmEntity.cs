using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45Tsi.Storage.Entity
{
    public class filmEntity
    {
        [Key]
        [Required]
        [Column("g_id")]
        public Guid id { get; set; }

        [Required]
        [Column("st_filmName")]
        [MaxLength(50)]
        public string filmName { get; set; }

        [Required]
        [Column("g_genreId")]
        public Guid genreId { get; set; }

        [Required]
        [Column("st_genreName")]
        [MaxLength(50)]
        public string genreName { get; set; }

        [Required]
        [Column("g_producerId")]
        public Guid producerId { get; set; }

        [Required]
        [Column("st_producerName")]
        [MaxLength(50)]
        public string producerName { get; set; }


    }
}
