using AutoMapper;
using DomainServices.Exception;
using Microsoft.AspNetCore.Http;
using Parnas.Domain.Entities;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Parnas.DomainService.Services
{
    public class GenericService<TEntity, TImage> : IGenericService<TEntity, TImage>
        where TEntity : class, IHasImage<TImage>, new()
        where TImage : ProductImage, new()
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
            var entity = _repository.GetByIdWithImages(id);
            var imageListProperty = entity.GetType().GetProperty("ImageList");
            if (imageListProperty == null)
                return null;

            var imageList = imageListProperty.GetValue(entity) as IEnumerable<object>;
            List<string> ImageList =  imageList?.Select(image => (string)image.GetType().GetProperty("ImageName").GetValue(image)).ToList() ?? new List<string>();

            var dto = _mapper.Map<TDto>(entity);

            var imageNamesProperty = dto.GetType().GetProperty("ImageList"); // نام پروپرتی را مطابق با DTO خود تنظیم کنید
            if (imageNamesProperty != null)
            {
                imageNamesProperty.SetValue(dto, ImageList);
            }

            return dto;
        }

        public List<TDto> GetAll<TDto>() where TDto : class
        {
            var entities = _repository.GetAll();
            return _mapper.Map<List<TDto>>(entities);
        }

        public ServiceException Add<TDto, TImage1>(TDto dto, List<IFormFile> files) where TDto : class
             where TImage1 : ProductImage, new()
        {
            var entity = _mapper.Map<TEntity>(dto);

            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    var extension = Path.GetExtension(file.FileName);
                    var uniqueFileName = $"{fileName}{extension}";
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/uploads", uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyToAsync(stream).Wait(); // Use .Wait() if not in an async method
                    }

                    var image = new TImage()
                    {
                        ImageName = uniqueFileName,
                        ImagePath = filePath
                    };

                    entity.ImageList.Add(image);
                }
            }

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

                    if (entity is IHasImage<ProductImage> hasImageEntity)
                    {
                        var productImage = new ProductImage
                        {
                            ImageName = fileName,
                            ImagePath = filePath
                        };
                        hasImageEntity.ImageList.Add(productImage);
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
