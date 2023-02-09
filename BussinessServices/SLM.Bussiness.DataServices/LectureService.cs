
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SLM.Bussines.Interfaces;
using SLM.Bussiness.Interfaces;
using SLM.Bussiness.Models;
using SLM.Data;
using SLM.Data.Interfaces;
using SLM.Data.Models;


namespace SLM.Bussiness.DataServices
{
    public class LectureService : GenericService<LectureModel, Lecture>, ILectureService
    {
        private readonly IRepository<Lecture> _repository;
        public LectureService(IRepository<Lecture> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        //List<LectureModel> lecture = new List<LectureModel>();
        //{
        //    if (ModelState.IsValid)
        //    {
        //        lecture.Id = model.Id;
        //        lecture.LectureName = model.LectureName;
        //        lecture.LectureDescription = model.LectureDescription;
        //        lecture.LectureURL = model.LectureURL;
        //        lecture.CourseId = model.CourseId;

        //        if (model.Id == 0)
        //        {
        //            DbSet.user_details.Add(obj); //insert data in table
        //            DbSet.SaveChanges(); //save changes in table
        //            return RedirectToAction("Teacher");
        //        }
        //        else
        //        {
        //            DbSet.Entry(obj).State = EntityState.Modified;
        //            DbSet.SaveChanges();

        //        }
        //    }
    }
}


    
