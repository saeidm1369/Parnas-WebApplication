using DomainServices.Exception;
using Microsoft.AspNetCore.Http;
using Parnas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.DomainService.Services
{
    public interface IGenericService<TEntity, TImage> where TEntity : class where TImage : ProductImage, new()
    {
        TDto GetById<TDto>(int id) where TDto : class;
        List<TDto> GetAll<TDto>() where TDto : class;
        ServiceException Add<TDto, TImage>(TDto dto, List<IFormFile> files) where TDto : class
        where TImage : ProductImage, new();
        ServiceException Update<TDto>(TDto dto, List<IFormFile> files, int id) where TDto : class;
        ServiceException Delete(int id);

    }
}
