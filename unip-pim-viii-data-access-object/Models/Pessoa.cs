using System.ComponentModel.DataAnnotations;

namespace unip_pim_viii_data_access_object.Models
{
    public class Pessoa: BaseModel
    {
        public string? nome { get; set; }
        public long cpf { get; set; }
        public virtual Endereco? endereco { get; set; }
        public virtual ICollection<Telefone>? telefones { get; set; }

    }
}
