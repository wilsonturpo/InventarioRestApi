namespace GEN_InventarioRestApi.DTO
{
    public class ProductoListDto
    {
        public int PROD_Id { get; set; }
        public string PROD_cDescripcion { get; set; }
        public decimal PROD_nPrecio { get; set; }
        public int PROD_nStock { get; set; }
        public int MEDI_Id { get; set; }
        public int SECC_Id { get; set; }
    }
}
