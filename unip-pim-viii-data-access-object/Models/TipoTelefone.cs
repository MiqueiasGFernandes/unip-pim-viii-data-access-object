using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace unip_pim_viii_data_access_object.Models
{
    public class TipoTelefone: BaseModel
    {
        public string? tipo { get; set; }
        [JsonIgnore]
        public virtual ICollection<Telefone>? telefones { get; set; }

    }
}
