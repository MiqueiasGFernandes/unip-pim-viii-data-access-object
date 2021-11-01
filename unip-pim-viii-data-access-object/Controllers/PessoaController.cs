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

        //[HttpPost]
        //public Pessoa Post(Pessoa pessoa)
        //{
        //        return PessoaDAO.insere(pessoa);
        //    } catch (Exception e)
        //    {
        //        return null;
        //    }
        //}


    }
}