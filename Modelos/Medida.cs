using System.ComponentModel.DataAnnotations;

namespace GEN_InventarioRestApi.Modelos
{
    public class Medida
    {
        [Key]
        public int MEDI_Id { get; set; }

        [StringLength(50)]
        public string MEDI_cTipo { get; set; }
        
        [StringLength(50)]
        public string MEDI_cDescripcion { get; set; }


        //Propiedades de navegación
        //public ICollection<Producto> Productos { get; set; }

    }
}
