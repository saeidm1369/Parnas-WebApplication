using DomainServices.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.DomainService.Services
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        TDto GetById<TDto>(string id) where TDto : class;
        IEnumerable<TDto> GetAll<TDto>() where TDto : class;
        ServiceException Add<TDto>(TDto dto) where TDto : class;
        ServiceException Update<TDto>(string id, TDto dto) where TDto : class;
        ServiceException Delete(string id);
    }
}
