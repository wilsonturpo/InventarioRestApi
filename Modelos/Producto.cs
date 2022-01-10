using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GEN_InventarioRestApi.Modelos
{
    public class Producto
    {
        [Key]
        public int PROD_Id { get; set; }
        [StringLength(50)]
        public string PROD_cDescripcion { get; set; }
        public decimal PROD_nPrecio { get; set; }
        public int PROD_nStock { get; set; }
        
        [ForeignKey("Medida")]
        public int MEDI_Id { get; set; }
        public Medida Medida { get; set; }

        [ForeignKey("Seccion")]
        public int SECC_Id { get; set; }
        public Seccion Seccion { get; set; }

    }
}
