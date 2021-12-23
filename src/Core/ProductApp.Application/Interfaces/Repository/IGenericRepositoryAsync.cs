using ProductApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces.Repository
{
    //T alacak Generic olacağı için.  
    public interface IGenericRepositoryAsync<T> where  T : BaseEntity //Where kullanarak T gönderilecek şeyi entity olarak kısıkladık(BaseEntity harici birşey gönderilemez).
    {
        //ById methodları süreklü bütün repositorylerin içinde olucak.Bu yüzden her repository içine aynı kodları yazmak yerine GenericRepository yazabiliriz.
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid Id);
        Task<T> AddAsync(T entity); //Entity gönderildiğinde bu method ile entitileri alıyoruz.

    }
}
