﻿using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		CampContext context = new CampContext();

		private readonly DbSet<T> _object;

		public GenericRepository()
		{
			_object = context.Set<T>();
		}
		//Burada yapılan şey GenerateRepository class'ı çağrıldığı anda bir _object nesnesi oluşturuluyor ve  bu nesneye context sınıfından gelen entity'i atıyor. T => Admin,Category,Product vs...

		public void Delete(T entity)
		{
			var deletedEntity = context.Entry(entity);
			deletedEntity.State = EntityState.Deleted;
			context.SaveChanges();
		}

		public List<T> GetAll()
		{
			return _object.ToList();
		}

		public T GetById(int id)
		{
			return _object.Find(id);
		}

		public void Insert(T entity)
		{
			var addedEntity = context.Entry(entity);
			addedEntity.State = EntityState.Added;
			context.SaveChanges();
		}

		public void Update(T entity)
		{
			var updatedEntity = context.Entry(entity);
			updatedEntity.State = EntityState.Modified;
			context.SaveChanges();
		}
	}
}
