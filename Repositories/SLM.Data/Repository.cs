﻿using Microsoft.EntityFrameworkCore;
using SLM.Data.Interfaces;
using SLM.Data.Models;
using System.Linq.Expressions;


namespace SLM.Data
{
   

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
	{

		private readonly SLManagementDbContext _context;
		protected readonly DbSet<TEntity> _dbSet;


		public Repository(SLManagementDbContext context)
		{
			_context = context;
			_dbSet = context.Set<TEntity>();
		}



		public IList<TEntity> GetAll()
		{
			return _dbSet.ToList();
		}

		public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
		{
			return _dbSet.Where(predicate);
		}
		public void Delete(TEntity entity)
		{


			if (entity == null)

				return;

			var dbEntity = _context.Entry(entity);
			if (dbEntity.State != EntityState.Deleted)
			{
				dbEntity.State = EntityState.Deleted;
			}
			else
			{
				_dbSet.Attach(entity);
				_dbSet.Remove(entity);

			}
			_context.SaveChanges();
		}

		public void Save(TEntity entity)
		{
			if (entity.Id > 0)
			{
				_dbSet.Attach(entity);
				_context.Entry(entity).State = EntityState.Modified;
			}
			else
			{
				_dbSet.Add(entity);
			}
			_context.SaveChanges();
		}
	}
}
