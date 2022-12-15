using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.models
{
    [Table("eva_cat_evaluacion", Schema = "sc_evaluacion")]
    public class Evaluacion
    {
        [Key]
        [Column("Cod_evaluacion")]
        [Display(Name = "Cod_evaluacion")]
        public string Cod_evaluación { get; set; }

        [Required]
        [Column("Desc_evaluacion")]
        [Display(Name = "Desc_evaluacion")]
        public string Desc_evaluacion { get; set; }

        /****************************** Campos Relacionales *********************************/

        [ForeignKey("Cod_evaluacion")]
        public virtual Notas? Notas { get; set; }
    }
}
