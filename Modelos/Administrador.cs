using System.ComponentModel.DataAnnotations;

namespace GEN_InventarioRestApi.Modelos
{
    public class Administrador
    {
        [Key]
        public int ADMI_Id { get; set; }

        [StringLength(50)]
        public string ADMI_cUsuario { get; set; }
        public string ADMI_cPassword { get; set; }

    }
}
