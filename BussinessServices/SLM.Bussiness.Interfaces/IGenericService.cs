namespace SLM.Bussiness.Interfaces
{
    public interface IGenericService<TModel>
    {
        List<TModel> GetAll();

        public void Add(TModel model);

        public void Update(TModel model);

        public void Details(int Id);

        public void Delete(int Id);
    }
}
