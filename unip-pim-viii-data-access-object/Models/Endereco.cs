using System.ComponentModel.DataAnnotations;

namespace unip_pim_viii_data_access_object.Models
{
    public class Endereco: BaseModel
    {
        public int cep { get; set; }
        public int numero { get; set; }
        public string? logradouro { get; set; }
        public string? bairro { get; set; }
        public string? cidade { get; set; }
        public string? estado { get; set; }
    }
}
