using BackEndClassOne.Application.Contract;
using BackEndClassOne.Common;
using BackEndClassOne.Domain.Contract;
using BackEndDataBase;

namespace BackEndClassOne.Application
{
    public class GameAppService : IGameAppService
    {
        readonly IGameDomainService _gameDomainService;
        public GameAppService(IGameDomainService gameDomainService) {
            _gameDomainService = gameDomainService;
        }
        public async Task<RequestResponse<int>> Add(Game game)
        {
            if(string.IsNullOrWhiteSpace(game.Name))
                return new RequestResponse<int>().CreateUnSuccesful("El nombre es obligado");

            return await Task.Run(() =>
            {
                return _gameDomainService.Add(game);
            });
        }

        public async Task<RequestResponse<Game>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RequestResponse<IEnumerable<Game>>> GetAll()
            => await Task.Run(_gameDomainService.GetAll);
    }
}
