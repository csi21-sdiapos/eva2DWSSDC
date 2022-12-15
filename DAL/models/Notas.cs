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
    [Table("eva_tch_notas_evaluacion", Schema = "sc_evaluacion")]
    public class Notas
    {
        [Required]
        [Column("md_uuid")]
        [Display(Name = "md_uuid")]
        public string Md_uuid { get; set; }

        [Required]
        [Column("Md_fch")]
        [Display(Name = "Md_fch")]
        public DateTime Md_fch { get; set; }

        
        [Column("Id_nota_evaluacion")]
        [Display(Name = "Id_nota_evaluacion")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_nota_evaluacion { get; set; }

        [Required]
        [Column("Cod_alumno")]
        [Display(Name = "Cod_alumno")]
        public string Cod_alumno { get; set; }

        [Required]
        [Column("Nota_evaluacion")]
        [Display(Name = "Nota_evaluacion")]
        public int Nota_evaluacion { get; set; }

        [Key]
        [Column("Cod_evaluacion")]
        [Display(Name = "Cod_evaluacion")]
        public string Cod_evaluación { get; set; }

        /****************************** Campos Relacionales *********************************/

        [InverseProperty("Notas")]
        public virtual List<Evaluacion>? ListaEvaluacion { get; set; }

    }
}
