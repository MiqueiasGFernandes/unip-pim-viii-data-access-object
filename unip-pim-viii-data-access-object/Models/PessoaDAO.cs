namespace unip_pim_viii_data_access_object.Models.DAO
{
    static public class PessoaDAO
    {
        private static PIMContext? connection;

        public static PIMContext setConnection(PIMContext context)
        {
            if (connection == null)
            {
                connection = context;
            };
            return connection;
        }

        public static bool exclua(Pessoa p)
        {
            try
            {
                connection.Pessoas.Remove(p);
                connection.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool insere(Pessoa p)
        {
            try
            {
                connection.Pessoas.Add(p);
                connection.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }

        public static IEnumerable<Pessoa> consulta(string? id)
        {
            try
            {
                if (id == null)
                {
                    var result = connection.Pessoas.ToList();
                    return result;
                }
                return (IEnumerable<Pessoa>)connection.Pessoas.Find(id);

            }
            catch (Exception e)
            {
                Pessoa[] result = new Pessoa[] { };
                return result;
            }
        }
        public static bool altere(Pessoa p)
        {
            try
            {
                connection.Pessoas.Update(p);
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
