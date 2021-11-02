using Microsoft.AspNetCore.Mvc;
using unip_pim_viii_data_access_object.Models.DAO;
using unip_pim_viii_data_access_object.Models;

namespace unip_pim_viii_data_access_object.Controllers
{
    [ApiController]
    [Route("/pessoas")]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
            PessoaDAO.setConnection(new PIMContext());
        }

        [HttpGet]
        public IEnumerable<Pessoa> Get(string? id)
        {
            return PessoaDAO.consulta(id);
        }

        [HttpPost]
        public bool Post(Pessoa pessoa)
        {
            try
            {
                PessoaDAO.insere(pessoa);
                return true;
            } catch(Exception e)
            {
                return false;
            }
        }

        [HttpPut]
        public bool Put(Pessoa pessoa)
        {
            try
            {
                PessoaDAO.altere(pessoa);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        [HttpDelete]
        public bool Delete([FromQuery] string id)
        {
            try
            {
                PessoaDAO.exclua(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}