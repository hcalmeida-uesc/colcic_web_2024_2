using System;

namespace UescColcicAPI.Services.BD.Interfaces;
// Contrato de CRUD
public interface IBaseCRUD<T>
{
      public void Create(T entity);
      public IEnumerable<T> ReadAll();
      public T? ReadById(int id);
      public void Update(T entity);
      public void Delete(T entity);
}
