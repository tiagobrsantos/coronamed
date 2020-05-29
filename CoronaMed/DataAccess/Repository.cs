using CoronaMed.DataAccess.Context;
using CoronaMed.Model.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoronaMed.DataAccess
{

	public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
	{
		private CoronaMedContext coronaMedContext { get; set; }

		public Repository(CoronaMedContext userContext)
		{
			coronaMedContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
		}
		public async Task<TEntity> AddAsync(TEntity obj)
		{

			coronaMedContext.Set<TEntity>();
			await coronaMedContext.AddAsync(obj);
			await coronaMedContext.SaveChangesAsync();

			return obj;
		}

		public async Task DeleteAsync(TEntity obj)
		{
			coronaMedContext.Remove(obj);
			await coronaMedContext.SaveChangesAsync();
		}

		public void Dispose()
		{
			if (coronaMedContext != null)
			{
				coronaMedContext.Dispose();
			}
			GC.SuppressFinalize(this);
		}

		public IQueryable<TEntity> Get()
		{
			return coronaMedContext.Set<TEntity>();
		}

		public IQueryable<TEntity> Get(Func<TEntity, bool> predicate, Expression<Func<TEntity, object>> includes)
		{
			return Get().Include(includes).Where(predicate).AsQueryable();
		}

		public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
		{
			return Get().Where(predicate).AsQueryable();
		}

		public async Task<TEntity> UpdateAsync(TEntity obj)
		{
			coronaMedContext.Set<TEntity>();
			coronaMedContext.Update(obj);
			await coronaMedContext.SaveChangesAsync();
			return obj;
		}
	}
}
