using AutoMapper;
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
        private IRepository<Lecture> repository;
        private IMapper mapper;

        public GenericService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public GenericService(IRepository<Lecture> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }



        //add data in databse we need to convert it into entity
        public List<TModel> GetAll()
        {
            var allEntity = _repository.GetAll();
            var allModel = _mapper.Map<List<TModel>>(allEntity);
            return allModel;
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
            var allEntity = _repository.GetAll();
            var allModel = _mapper.Map<List<TModel>>(allEntity);
            //_repository.Get(allModel);

            //part:8 , 21:55
            //var entity = _repository.Get(x => x.Id == Id).FirstOrDefault();
            //var entity = _mapper.Map<TEntity>(Id);
            //return entity;
            //check
            //_repository.Get(entity);
        }

        public void Update(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);
            _repository.Save(entity);
        }
        public void Delete(int Id)
        {
            var entity = _repository.Get(x=> x.Id == Id).FirstOrDefault();
            if (entity != null)
            {
                _repository.Delete(entity);
            }
        }

       
       
       
    }
}
