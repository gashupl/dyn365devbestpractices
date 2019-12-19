using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter06.Plugins.Common;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;

namespace Chapter06.Plugins.Repositories
{
    public class RepositoryBase : IRepositoryBase
    {

        protected IOrganizationService Service { get; set; }

        public RepositoryBase()
        {
        }

        public virtual IRepositoryBase Initialize(ICdsServiceProvider serviceProvider)
        {
            this.Service = serviceProvider.Service;
            return this;
        }

        public Entity GetById(string entityLocalName, Guid entId)
        {
            return this.Service.Retrieve(entityLocalName, entId, new ColumnSet(true));
        }

        public IList<Entity> GetByAttribute(string entityLocalName, string attributeName, object value, int? limitResult = 50)
        {
            var query = new QueryByAttribute(entityLocalName);
            query.AddAttributeValue(attributeName, value);

            if (limitResult != null)
                query.TopCount = limitResult;

            var result = this.Service.RetrieveMultiple(query);

            if (result == null || result.Entities == null || result.Entities.Count == 0)
                return null;
            else
                return result.Entities.ToList();
        }

        public Guid Create(Entity entity)
        {
            var id = this.Service.Create(entity);
            entity.Id = id;
            return id;
        }

        public void Upsert(Entity entity)
        {
            UpsertRequest request = new UpsertRequest()
            {
                Target = entity
            };

            this.Service.Execute(request);
        }

        public void Update(Entity entity)
        {
            this.Service.Update(entity);
        }

        public void Delete(EntityReference enRef)
        {
            this.Service.Delete(enRef.LogicalName, enRef.Id);
        }

        public void Associate(EntityReference entity, Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            this.Service.Associate(entity.LogicalName, entity.Id, relationship, relatedEntities);
        }

        public void Associate(EntityReference entity, string relationship, IList<EntityReference> relatedEntities)
        {
            EntityReferenceCollection collection = new EntityReferenceCollection();
            collection.AddRange(relatedEntities);

            this.Service.Associate(entity.LogicalName, entity.Id, new Relationship(relationship), collection);
        }

        public void Disassociate(EntityReference entity, Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            this.Service.Disassociate(entity.LogicalName, entity.Id, relationship, relatedEntities);
        }

        public void Disassociate(EntityReference entity, string relationship, IList<EntityReference> relatedEntities)
        {
            EntityReferenceCollection collection = new EntityReferenceCollection();
            collection.AddRange(relatedEntities);

            this.Service.Disassociate(entity.LogicalName, entity.Id, new Relationship(relationship), collection);
        }

        public GrantAccessResponse GrantAccess(EntityReference entityId, EntityReference principal, AccessRights accessRights)
        {
            return (GrantAccessResponse) Service.Execute(new GrantAccessRequest()
            {
                Target = entityId,
                PrincipalAccess = new PrincipalAccess()
                {
                    Principal = principal,
                    AccessMask = accessRights,
                }
            });
        }

        public RevokeAccessResponse RevokeAccess(EntityReference entityId, EntityReference principal)
        {
            return (RevokeAccessResponse) Service.Execute(new RevokeAccessRequest()
            {
                Target = entityId,
                Revokee = principal,
            });
        }

        public AssignResponse AssignUser(EntityReference entityId, EntityReference ownerId)
        {
            AssignRequest req = new AssignRequest();
            req.Assignee = ownerId;
            req.Target = entityId;
            return (AssignResponse) this.Service.Execute(req);
        }


        public OrganizationResponse Execute(OrganizationRequest request)
        {
            return this.Service.Execute(request);
        }

        public RetrieveEntityResponse RetrieveEntity(RetrieveEntityRequest request)
        {
            return (RetrieveEntityResponse) this.Service.Execute(request);
        }

        public EntityMetadata GetEntityMetadata(RetrieveEntityRequest request)
        {
            RetrieveEntityResponse response = (RetrieveEntityResponse) this.Service.Execute(request);
            return (EntityMetadata) response.EntityMetadata;
        }

        public void SharePrivileges(EntityReference targetEntity, EntityReference assigneeRef, bool readAccess, bool writeAccess, bool appendAccess)
        {
            try
            {
                AccessRights accessRights = new AccessRights();
                accessRights = AccessRights.None;
                //Read Access           
                if (readAccess == true)
                    accessRights = AccessRights.ReadAccess;
                //Write Access (or) Read, Write Access        
                if (writeAccess == true)
                    if (accessRights == AccessRights.None)
                        accessRights = AccessRights.WriteAccess;
                    else
                        accessRights = accessRights | AccessRights.WriteAccess;
                //Append Access or all or any two accesses         
                if (appendAccess == true)
                    if (accessRights == AccessRights.None)
                        accessRights = AccessRights.AppendToAccess | AccessRights.AppendAccess;
                    else
                        accessRights = accessRights | AccessRights.AppendToAccess | AccessRights.AppendAccess;
                var grantAccess = new GrantAccessRequest
                {
                    PrincipalAccess = new PrincipalAccess
                    {
                        AccessMask = accessRights,
                        Principal = assigneeRef
                    },
                    Target = targetEntity
                };
                // Execute the Request      
                this.Service.Execute(grantAccess);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while applying Sharing rules for the record." + ex.Message +
                                    assigneeRef.Id + "|| " + targetEntity.Id);
            }
        }

    }
}
