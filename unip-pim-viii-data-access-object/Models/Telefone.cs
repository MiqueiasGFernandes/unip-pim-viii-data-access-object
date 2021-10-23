namespace unip_pim_viii_data_access_object.Models
{
    public class Telefone
    {
        protected int id;
        public TipoTelefone? tipo;
        public int ddd;
        public int telefone;

        public Telefone(int id, TipoTelefone tipo, int ddd, int telefone) { 
            this.id = id;
            this.tipo = tipo;
            this.ddd = ddd;
            this.telefone = telefone;
        }
    }
}
