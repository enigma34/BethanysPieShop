using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BethanysPieShop.Models
{
    public class PieRepository:IPieRepository
    {
        private readonly AppDBContext _appDbContext;

        public PieRepository(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPie()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPie(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}