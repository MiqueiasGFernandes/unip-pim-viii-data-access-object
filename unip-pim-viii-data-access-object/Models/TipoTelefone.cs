using System.ComponentModel.DataAnnotations;

namespace unip_pim_viii_data_access_object.Models
{
    public class TipoTelefone
    {
        [Key]
        public int id { get; set; }
        public string? tipo { get; set; }

    }
}
