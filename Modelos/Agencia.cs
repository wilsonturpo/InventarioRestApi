using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GEN_InventarioRestApi.Modelos
{
    public class Agencia
    {
        [Key]
        public int AGEN_Id { get; set; }
        [StringLength(50)]
        public string AGEN_cDescripcion { get; set;}

        [ForeignKey("Administrador")]
        public int ADMI_Id { get; set; }
        public Administrador Administrador { get; set; }
    }
}
