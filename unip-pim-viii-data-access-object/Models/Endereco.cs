namespace unip_pim_viii_data_access_object.Models
{
    public class Endereco
    {
        protected int id;
        public int cep;
        public int numero;
        public string? logradouro;
        public string? bairro;
        public string? cidade;
        public string? estado;

        public Endereco(int id, int cep, int numero, string logradouro, string bairro, string cidade, string estado)
        {
            this.id = id;
            this.numero = numero;
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
        }
    }
}
