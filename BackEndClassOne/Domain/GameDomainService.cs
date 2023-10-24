using BackEndClassOne.Common;
using BackEndClassOne.Domain.Contract;
using BackEndDataBase;

namespace BackEndClassOne.Domain
{
    public class GameDomainService : IGameDomainService
    {

        readonly ClassContext _context;

        public GameDomainService(ClassContext classContext)
        {
            _context = classContext;
        }
        public RequestResponse<int> Add(Game game)
        {
            _context.Add(game);
            _context.SaveChanges();

            return new RequestResponse<int>().CreateSuccesful(1, "El registro se creó existosamente");
        }

        public RequestResponse<Game> Get(int id)
         =>  new RequestResponse<Game>().CreateSuccesful(_context.Games.FirstOrDefault(f => f.Id.Equals(id)));

        public RequestResponse<IEnumerable<Game>> GetAll()
            => new RequestResponse<IEnumerable<Game>>().CreateSuccesful(_context.Games.AsEnumerable());
        
    }
}
