namespace unip_pim_viii_data_access_object.Models
{
    public class Pessoa
    {
        protected int id;
        public string? nome;
        public long cpf;
        public Endereco? endereco;
        public Telefone[]? telefones;

        public Pessoa(int id, string nome, long cpf, Endereco endereco, Telefone[] telefones)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefones = telefones;
        }
    }
}
