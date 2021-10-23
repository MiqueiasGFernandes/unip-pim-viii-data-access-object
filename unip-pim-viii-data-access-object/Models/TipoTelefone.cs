namespace unip_pim_viii_data_access_object.Models
{
    public class TipoTelefone
    {
        protected int id;
        public string tipo;

        public TipoTelefone(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }
    }
}
