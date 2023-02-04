﻿using SLM.Bussiness.Interfaces;
using SLM.Bussiness.Models;


namespace SLM.Bussines.Interfaces
{
    public interface ICourseService : IGenericService<CoursesModel>
    {
        public List<CoursesModel> Search(string searchTerm);

    }
}
