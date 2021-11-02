using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace unip_pim_viii_data_access_object.Models
{
    public class Telefone: BaseModel
    {
        public virtual TipoTelefone? tipo { get; set; }
        [JsonIgnore]
        public virtual Pessoa? pessoa { get; set; }
        public int ddd { get; set; }
        public int telefone { get; set; }

    }
}
