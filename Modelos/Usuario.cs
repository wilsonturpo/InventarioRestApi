using System.ComponentModel.DataAnnotations;

namespace GEN_InventarioRestApi.Modelos
{
    public class Usuario
    {
        [Key]
        public int USUA_id { get; set; }

        [StringLength(50)]
        public string USUA_cNombre { get; set; }
        public string USUA_cPassword { get; set; }

    }
}
