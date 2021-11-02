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

        public static bool exclua(string id)
        {
            try
            {

                foreach (Pessoa current in connection.Pessoas.ToList())
                {
                    if (current.id == Int32.Parse(id))
                    {
                        connection.Pessoas.Remove(current);
                        connection.SaveChanges();
                        break;
                    }
                }


                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static void insere(Pessoa p)
        {
            connection.Pessoas.Add(p);
            connection.SaveChanges();
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
        public static void altere(Pessoa p)
        {
            connection.Pessoas.Update(p);
            connection.SaveChanges();
        }
    }
}
