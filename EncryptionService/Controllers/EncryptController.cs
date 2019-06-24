using Microsoft.AspNetCore.Mvc;
using EncryptionService.Services;

namespace EncryptionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncryptController : ControllerBase 
    {
        IEncryptionService _encryptionService;

        public EncryptController(IEncryptionService EncryptionService)
        {
            _encryptionService = EncryptionService;
        }


        [HttpGet("{password}")]
        public ActionResult<string> Get(string password)
        {
            return _encryptionService.EncryptPassword(password);
        }
    }
}