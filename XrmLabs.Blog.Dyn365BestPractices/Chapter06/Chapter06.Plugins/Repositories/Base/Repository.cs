using System;
using System.Collections.Generic;
using System.Linq;
using Common.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;

namespace Chapter06.Plugins.Repositories.Base
{
    public partial class Repository<E> : RepositoryBase, IRepository<E> where E : Entity
    {
        protected Dyn365ServiceContext CdsContext { get; set; }

        //public override IRepository Initialize(ICdsServiceProvider serviceProvider)
        //{
        //    base.Initialize(serviceProvider);
        //    this.XrmContext = serviceProvider.ServiceContext; 
        //    return this;
        //}

        protected string LogicalName
        {
            get
            {
                string result = string.Empty;
                var field = typeof(E).GetField("EntityLogicalName");
                if (field != null && field.IsStatic)
                {
                    result = (string)field.GetValue(null); // field is static.
                }
                return result;
            }
        }

        //Methods
        protected IQueryable<E> GetAll()
        {
            return this.CdsContext.CreateQuery<E>();
        }

        public E GetById(Guid id, Func<E, E> selector = null)
        {
            var query = this.GetAll();

            if (selector != null)
            {
                return query.Where(q => q.Id == id).Select(selector).Single();
            }

            return query.Where(q => q.Id == id).Single();
        }

        public E GetById(EntityReference enRef, Func<E, E> selector = null)
        {
            if (enRef == null)
            {
                return null;
            }

            return GetById(enRef.Id, selector);
        }

        public IList<E> GetAllForJoin(Func<E, bool> predicate)
        {
            return this.GetAll().ToList();
        }

        public IList<E> GetByAttribute(string attributeName, object value, Func<E, E> selector = null, int? limitResult = 50)
        {
            var query = GetAll().Where(i => i[attributeName] == value);

            if (limitResult != null)
            {
                query.Take(limitResult.Value);
            }

            if (selector != null)
            {
                return query.Select(selector).ToList();
            }

            return query.ToList();
        }

        public Guid Create(E entity)
        {
            var id = this.Service.Create(entity);
            entity.Id = id;
            return id;
        }

        public void Update(E entity)
        {
            this.Service.Update(entity);
        }

        public void Upsert(E entity)
        {
            UpsertRequest request = new UpsertRequest()
            {
                Target = entity
            };

            this.Service.Execute(request);
        }

        public void Delete(Guid id)
        {
            this.Service.Delete(this.LogicalName, id);
        }

    }
}
