﻿using AutoMapper;
using SLM.Bussiness.Interfaces;
using SLM.Data.Interfaces;
using SLM.Data.Models;


namespace SLM.Bussiness.DataServices
{
    //TModel => bussiness model and TEntity=> presentation of database table and DaseEntity consist of Id
    public class GenericService<TModel, TEntity> : IGenericService<TModel> where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

       
        public List<TModel> GetAll()
        {
            var allEntity = _repository.GetAll();
            var allModel = _mapper.Map<List<TModel>>(allEntity);
            return allModel;
        }

        public TModel GetById(int Id)
        {
            var entity = _repository.Get(x=> x.Id==Id).FirstOrDefault();
            var model = _mapper.Map<TModel>(entity);
            return model;
        }

        //convert model into TEntity
        public void Add(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            _repository.Save(entity);
        }

        public void Details(int Id)
        //public List<TModel> Details(int Id)
        {
            var entity = _repository.Get(x => x.Id == Id).FirstOrDefault();
            var model = _mapper.Map<TModel>(entity);
            
        }

        public void Update(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            _repository.Save(entity);
        }
        public void Delete(int Id)
        {
            var entity = _repository.Get(x => x.Id == Id).FirstOrDefault();
            if (entity != null)
            {
                _repository.Delete(entity);
            }
        }




    }
}
