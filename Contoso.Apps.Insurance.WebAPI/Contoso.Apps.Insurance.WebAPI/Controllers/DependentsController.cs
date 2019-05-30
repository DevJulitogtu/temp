using System.Collections.Generic;
using System.Linq;
using Contoso.Apps.Insurance.Data;
using Contoso.Apps.Insurance.Data.Logic;
using Contoso.Apps.Insurance.Data.Mapping;
using Microsoft.AspNetCore.Mvc;
using Dependent = Contoso.Apps.Insurance.Data.DTOs.Dependent;

namespace Contoso.Apps.Insurance.WebAPI.Controllers
{
    public class DependentsController : ControllerBase
    {
        private readonly string _connectionString = EncryptionHelper.SecretConnectionString;

        // DELETE api/dependents/5
        public void DeleteDependent(int dependentId)
        {
            using (var actions = new DependentActions(_connectionString))
            {
                actions.DeleteDependent(dependentId);
            }
        }

        // GET api/dependents/5
        public Dependent GetDependent(int id)
        {
            Dependent dependent;
            // TODO: Review
            using (var ctx = new ContosoInsuranceContext(_connectionString))
            {
                dependent = DependentMapping.MapEntityToDto(ctx.Dependents.FirstOrDefault(p => p.Id == id));
            }

            return dependent;
        }

        public IList<Dependent> GetDependentsByPolicyHolder(int policyHolderId)
        {
            List<Dependent> dependents;

            using (var actions = new DependentActions(_connectionString))
            {
                dependents = actions.GetDependentsByPolicyHolder(policyHolderId).Select(DependentMapping.MapEntityToDto).ToList();
            }

            return dependents;
        }

        public int SaveDependent(Dependent dependent)
        {
            using (var actions = new DependentActions(_connectionString))
            {
                var dependentModel = DependentMapping.MapDtoToEntity(dependent);
                actions.SaveDependent(dependentModel);
                dependent.Id = dependentModel.Id;
            }
            return dependent.Id;
        }
    }
}