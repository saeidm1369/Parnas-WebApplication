using AutoMapper;
using DomainServices.Exception;
using Microsoft.AspNetCore.Http;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.DomainService.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper; 
        }

        public TDto GetById<TDto>(int id) where TDto : class
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<TDto>(entity);
        }

        public List<TDto> GetAll<TDto>() where TDto : class
        {
            var entities = _repository.GetAll();
            return _mapper.Map<List<TDto>>(entities);
        }

        public ServiceException Add<TDto>(TDto dto, List<IFormFile> files) where TDto : class
        {
            var entity = _mapper.Map<TEntity>(dto);

            #region Save Images file
            var imageUrls = new List<string>();
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    var extension = Path.GetExtension(file.FileName);
                    var uniqueFileName = $"{fileName}_{Guid.NewGuid()}{extension}";
                    var filePath = Path.Combine("wwwroot/images/uploads", uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyToAsync(stream);
                    }

                    imageUrls.Add($"/images/{uniqueFileName}");

                    if (entity is IHasImage hasImageEntity)
                    {
                        hasImageEntity.ImageName = fileName;
                        hasImageEntity.ImagePath = filePath;
                    }
                }
            }
            #endregion

            _repository.Create(entity);
            return ServiceException.Create(
                type: "Success");
        }

        public ServiceException Update<TDto>(TDto dto, List<IFormFile> files) where TDto : class
        {
            if (dto == null)
                return ServiceException.Create(
                type: "NotFound");

            var entity = _mapper.Map<TEntity>(dto);

            #region Save Images file
            var imageUrls = new List<string>();
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    var extension = Path.GetExtension(file.FileName);
                    var uniqueFileName = $"{fileName}_{Guid.NewGuid()}{extension}";
                    var filePath = Path.Combine("wwwroot/images/uploads", uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyToAsync(stream);
                    }

                    imageUrls.Add($"/images/{uniqueFileName}");

                    if (entity is IHasImage hasImageEntity)
                    {
                        hasImageEntity.ImageName = fileName;
                        hasImageEntity.ImagePath = filePath;
                    }
                }
            }
            #endregion

            _repository.Update(entity);
            return ServiceException.Create(
                type: "Success");
        }

        public ServiceException Delete(int id)
        {
            if (id == 0)
                return ServiceException.Create(
                type: "NotFound");

            _repository.DeleteById(id);
            return ServiceException.Create(
                type: "Success");
        }
    }

}
