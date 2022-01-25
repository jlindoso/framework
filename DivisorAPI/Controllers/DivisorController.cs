using businesslayer;
using businesslayer.Interfaces;
using businesslayer.Models.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DivisorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisorController : ControllerBase
    {
        public IDivisorService _divisorService { get; set; }
        public DivisorController(IDivisorService divisorService)
        {
            _divisorService = divisorService;
        }

        // POST api/<DivisorController>
        [HttpPost]
        public ActionResult<ResultDTO> Post(DivisorInputDTO input)
        {
            return Ok(_divisorService.GetDivisors(input.InputNumber));
        }

       
    }
}
