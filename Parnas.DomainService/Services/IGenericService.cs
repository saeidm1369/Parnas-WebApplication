using DomainServices.Exception;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.DomainService.Services
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        TDto GetById<TDto>(int id) where TDto : class;
        List<TDto> GetAll<TDto>() where TDto : class;
        ServiceException Add<TDto>(TDto dto, List<IFormFile> files) where TDto : class;
        ServiceException Update<TDto>(TDto dto, List<IFormFile> files) where TDto : class;
        ServiceException Delete(int id);

    }
}
