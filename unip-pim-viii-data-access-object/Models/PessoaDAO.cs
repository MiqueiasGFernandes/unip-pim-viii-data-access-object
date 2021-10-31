namespace unip_pim_viii_data_access_object.Models.DAO
{
    static public class PessoaDAO
    {
        private static PIMContext? connection;

        public static PIMContext setConnection(PIMContext context)
        {
            if(connection == null)
            {
                connection = context;
            };
            return connection;
        }

        public static bool exclua(Pessoa p) {
            try
            {
                connection.Remove(p);
                connection.SaveChanges();

                return true;
            } catch (Exception e)
            {
                return false;
            }
        }
        public static bool insere(Pessoa p) {
            try{
                connection.Add(p);
                connection.SaveChanges();

                return true;
            } catch (Exception e)
            {
                return false;
            }
        }
        public static bool consulta(Pessoa p) {
            try
            {
                connection.Find(p);
                connection.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool altere(Pessoa p) {
            try
            {
                connection.Update(p);
                connection.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
