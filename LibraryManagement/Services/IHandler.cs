using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LibraryManagement.Services
{
    public interface IHandler<T> where T: class
    {
        //return list entity
        List<T> GetAll();
        //add new entity
        bool Create(T entity);
        //edit entity
        bool Update(T entity);
        //delete entity
        bool Delete(int id);
        //get entity by id
        T GetById(int id);

    }
}