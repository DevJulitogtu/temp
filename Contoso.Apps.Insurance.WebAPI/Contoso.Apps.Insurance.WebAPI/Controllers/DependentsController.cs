using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        /// <response code="200">Ok.</response>
        /// <response code="404">NotFound.</response>
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
            Contoso.Apps.Insurance.Data.DTOs.Dependent dependent;

            using (var ctx = new ContosoInsuranceContext(_connectionString))
            {
                dependent = DependentMapping.MapEntityToDto(ctx.Dependents.FirstOrDefault(p => p.Id == id));
            }

            return dependent;
        }

        public IList<Contoso.Apps.Insurance.Data.DTOs.Dependent> GetDependentsByPolicyHolder(int policyHolderId)
        {
            List<Contoso.Apps.Insurance.Data.DTOs.Dependent> dependents;

            using (var actions = new DependentActions(_connectionString))
            {
                dependents = actions.GetDependentsByPolicyHolder(policyHolderId).Select(DependentMapping.MapEntityToDto).ToList();
            }

            return dependents;
        }

        public int SaveDependent(Contoso.Apps.Insurance.Data.DTOs.Dependent dependent)
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