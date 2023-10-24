using BackEndClassOne.Common;
using BackEndDataBase;

namespace BackEndClassOne.Application.Contract
{
    public interface IGameAppService
    {
        public Task<RequestResponse<IEnumerable<Game>>> GetAll();

        public Task<RequestResponse<Game>> Get(int id);

        public Task<RequestResponse<int>> Add(Game game);
    }
}
