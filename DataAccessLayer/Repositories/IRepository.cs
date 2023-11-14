using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositoreis
{
    public interface IRepository<T>
    {
        Task<List<T>> GetList();

        Task<bool> Insert(T Entity);

        Task<bool> Attach(T Entity);

        Task<bool> Update(T Entity);

        Task<bool> Delete(int Id);

        Task<T> Get(int Id);


        Task<List<T>> GetList_WithNewContext();

        Task<bool> Insert_WithNewContext(T Entity);

        Task<bool> Attach_WithNewContext(T Entity);

        Task<bool> Update_WithNewContext(T Entity);

        Task<bool> Delete_WithNewContext(int Id);

        Task<T> Get_WithNewContext(int Id);

    }

}
