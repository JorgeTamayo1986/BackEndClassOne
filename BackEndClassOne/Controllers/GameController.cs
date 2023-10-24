using BackEndClassOne.Application.Contract;
using BackEndClassOne.Common;
using BackEndDataBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BackEndClassOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        readonly IGameAppService _gameAppService;
        public GameController(IGameAppService gameAppService)
        {
            _gameAppService = gameAppService;
        }

        [HttpPost]
        [Route(nameof(GameController.Add))]
        public async Task<RequestResponse<int>> Add(Game game)
            => await _gameAppService.Add(game);


        [HttpGet]
        [Route(nameof(GameController.GetAll))]
        public async Task<RequestResponse<IEnumerable<Game>>> GetAll() 
            => await _gameAppService.GetAll();


    }
}
