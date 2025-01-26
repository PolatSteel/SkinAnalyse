using DataAccessLayer.Abstruct;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{

		private readonly SkinAnalyseContext context;

		public GenericRepository(SkinAnalyseContext context)
		{
			this.context = context;
		}

		public void Add(T entity)
		{
			context.Set<T>().Add(entity);
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var values = context.Set<T>().Find(id);
			context.Set<T>().Remove(values);
			context.SaveChanges();
		}

		public List<T> GetAll()
		{
			return context.Set<T>().ToList();
		}

		public T GetById(int id)
		{
			return context.Set<T>().Find(id);
		}

		public void Update(T entity)
		{
			context.Set<T>().Update(entity);
			context.SaveChanges();
		}
	}
}
