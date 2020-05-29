using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoronaMed.Model.Repository
{
	public interface IRepository<TEntity>
	{
		IQueryable<TEntity> Get();
		IQueryable<TEntity> Get(Func<TEntity, bool> predicate, Expression<Func<TEntity, object>> includes);
		IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
		Task<TEntity> AddAsync(TEntity obj);
		Task<TEntity> UpdateAsync(TEntity obj);
		Task DeleteAsync(TEntity obj);
	}
}
