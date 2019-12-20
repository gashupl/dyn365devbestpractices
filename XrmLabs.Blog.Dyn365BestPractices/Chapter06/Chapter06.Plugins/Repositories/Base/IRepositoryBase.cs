using System;
using System.Collections.Generic;
using Chapter06.Plugins.Common;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;

namespace Chapter06.Plugins.Repositories.Base
{
    public interface IRepositoryBase
    {
        IRepositoryBase Initialize(ICdsServiceProvider serviceProvider);

        Guid Create(Entity entity);

        void Delete(EntityReference enRef);

        IList<Entity> GetByAttribute(string entityLocalName, string attributeName, object value, int? limitResult = 50);

        Entity GetById(string entityLocalName, Guid entId);

        void Update(Entity entity);

        void Upsert(Entity entity);

        void Associate(EntityReference entity, Relationship relationship,  EntityReferenceCollection relatedEntities);

        void Associate(EntityReference entity, string relationship, IList<EntityReference> relatedEntities);

        void Disassociate(EntityReference entity, Relationship relationship, EntityReferenceCollection relatedEntities);

        void Disassociate(EntityReference entity, string relationship, IList<EntityReference> relatedEntities);

        GrantAccessResponse GrantAccess(EntityReference entityId, EntityReference principal, AccessRights accessRights);

        RevokeAccessResponse RevokeAccess(EntityReference entityId, EntityReference principal);

        AssignResponse AssignUser(EntityReference entityId, EntityReference ownerId);

        OrganizationResponse Execute(OrganizationRequest request);

        RetrieveEntityResponse RetrieveEntity(RetrieveEntityRequest request);

        void SharePrivileges(EntityReference targetEntity, EntityReference assigneeRef, bool readAccess,  bool writeAccess, bool appendAccess);
    }
}
