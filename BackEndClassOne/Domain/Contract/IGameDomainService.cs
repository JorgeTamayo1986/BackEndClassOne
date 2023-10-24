using BackEndClassOne.Common;
using BackEndDataBase;

namespace BackEndClassOne.Domain.Contract
{
    public interface IGameDomainService
    {
        public RequestResponse<IEnumerable<Game>> GetAll();

        public RequestResponse<Game> Get(int id);

        public RequestResponse<int> Add(Game game);
    }
}
