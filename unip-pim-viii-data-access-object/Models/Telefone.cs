using System.ComponentModel.DataAnnotations;

namespace unip_pim_viii_data_access_object.Models
{
    public class Telefone
    {
        [Key]
        public int id { get; set; }
        public TipoTelefone? tipo { get; set; }
        public int ddd { get; set; }
        public int telefone { get; set; }

    }
}
