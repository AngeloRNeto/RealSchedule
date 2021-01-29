using RealSchedule.Domain.Models;
using RealSchedule.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace RealSchedule.Entity.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private readonly RealScheduleContext context;
        private IDbSet<T> entities;
        string errorMessage = string.Empty;

        public BaseRepository(RealScheduleContext context)
        {
            this.context = context;
        }

        //Nomeclatura "virtual" para sobrepor o metodo
        //Em suas suas classes "filhas"
        public virtual T GetById(int id)
        {
            return this.Entities.Find(id);
        }
        public virtual List<T> GetAll<TEntity>()
        {
            return this.Entities.Where(e => e.Situacao == Domain.Enum.Situacao.Ativo).ToList();
        }

        public virtual int Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                //this.Entities.Add(entity);
                context.Set<T>().Add(entity);
                return context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                    }
                }
                throw new Exception(errorMessage, dbEx);
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw new Exception(errorMessage, dbEx);
            }
        }

        public virtual void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                this.Entities.Remove(entity);
                this.context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                throw new Exception(errorMessage, dbEx);
            }
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        private IDbSet<T> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = context.Set<T>();
                }
                return entities;
            }
        }
    }
}
