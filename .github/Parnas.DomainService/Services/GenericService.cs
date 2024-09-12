using AutoMapper;
using DomainServices.Exception;
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

        public TDto GetById<TDto>(string id) where TDto : class
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<TDto>(entity);
        }

        public IEnumerable<TDto> GetAll<TDto>() where TDto : class
        {
            var entities = _repository.GetAll();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public ServiceException Add<TDto>(TDto dto) where TDto : class
        {
            var entity = _mapper.Map<TEntity>(dto);
            _repository.Create(entity);
            return ServiceException.Create(
                type: "Success");
        }

        public ServiceException Update<TDto>(string id, TDto dto) where TDto : class
        {
            if (id == null)
                return ServiceException.Create(
                type: "NotFound");

            var entity = _mapper.Map<TEntity>(dto);
            _repository.Update(id, entity);
            return ServiceException.Create(
                type: "Success");
        }

        public ServiceException Delete(string id)
        {
            if (id == null)
                return ServiceException.Create(
                type: "NotFound");

            _repository.DeleteById(id);
            return ServiceException.Create(
                type: "Success");
        }
    }

}
