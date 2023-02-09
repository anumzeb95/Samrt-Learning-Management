﻿namespace SLM.Bussiness.Models
{
	public class LectureModel
	{
		public LectureModel()
		{
			Lectures = new List<LectureModel>();
		}
		public int Id { get; set; }
		public string LectureName { get; set; }

		public string LectureDescription { get; set; }

		public string LectureURL { get; set; }

		public int CourseId { get; set; }

		public ICollection<LectureModel> Lectures { get; set; }
	}



}
