using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AC4_PersistenciaBBDD.DTOs;

namespace AC4_PersistenciaBBDD.Persistence.DAO
{
    public interface IComarcaDAO
    {
        ComarcaDTO GetComarcaById(int id);
        public IEnumerable<ComarcaDTO> GetAllComarca();
        void AddComarca(ComarcaDTO comarca);
        void UpdateComarca(ComarcaDTO comarca);
        void DeleteComarca(int id);
    }
}
