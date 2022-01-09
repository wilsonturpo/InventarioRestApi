using System.ComponentModel.DataAnnotations;

namespace GEN_InventarioRestApi.Modelos
{
    public class Seccion
    {
        [Key]
        public int SECC_Id { get; set; }
        [StringLength(50)]
        public string SECC_cDescripcion { get; set;}
    }
}
