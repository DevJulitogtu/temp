using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.Apps.Insurance.WebAPI.Controllers
{
    public class PolicyHoldersController : ControllerBase
    {
        private readonly string _connectionString = EncryptionHelper.SecretConnectionString;

        // DELETE api/policyholders/5
        public void DeletePolicyHolder(int policyHolderId)
        {
            using (var actions = new PolicyActions(_connectionString))
            {
                actions.DeletePolicyHolder(policyHolderId);
            }
        }

        // GET api/policyholders/5
        public Data.DTOs.PolicyHolder GetPolicyHolder(int id)
        {
            Data.DTOs.PolicyHolder policyHolder;

            using (var ctx = new ContosoInsuranceContext(_connectionString))
            {
                var policyHolderData = ctx.PolicyHolders.Include(p => p.Policy)
                    .Include(p => p.Person).Include(p => p.Dependents).FirstOrDefault(p => p.Id == id);
                policyHolder = PolicyHolderMapping.MapEntityToDto(policyHolderData);
            }

            return policyHolder;
        }

        // GET api/policyholders
        public IList<PolicyHolderViewModel> GetPolicyHolders()
        {
            List<PolicyHolderViewModel> policies;

            using (var ctx = new ContosoInsuranceContext(_connectionString))
            {
                var policyHolders = ctx.PolicyHolders.Include(p => p.Policy).Include(p => p.Person)
                    .Include(p => p.Dependents).OrderBy(p => p.Person.LName).ToList();
                policies = policyHolders.Select(PolicyHolderMapping.MapEntityToViewModel).ToList();
            }

            return policies;
        }

        public int SavePolicyHolder([FromBody]Data.DTOs.PolicyHolder policyHolder)
        {
            using (var actions = new PolicyActions(_connectionString))
            {
                var policyHolderModel = PolicyHolderMapping.MapDtoToEntity(policyHolder);
                actions.SavePolicyHolder(policyHolderModel);
                policyHolder.Id = policyHolderModel.Id;
            }
            return policyHolder.Id;
        }
    }
}