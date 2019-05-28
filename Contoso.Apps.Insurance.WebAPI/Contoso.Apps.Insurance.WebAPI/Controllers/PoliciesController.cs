using System.Collections.Generic;
using System.Linq;
using System.Net;
using Contoso.Apps.Insurance.Data;
using Contoso.Apps.Insurance.Data.Mapping;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.Apps.Insurance.WebAPI.Controllers
{
    public class PoliciesController : ControllerBase
    {
        private readonly string _connectionString = EncryptionHelper.SecretConnectionString;

        // GET api/policies
        public IList<Data.DTOs.Policy> GetPolicies()
        {
            List<Data.DTOs.Policy> policies;

            using (var ctx = new ContosoInsuranceContext(_connectionString))
            {
                policies = ctx.Policies.ToList().Select(PolicyMapping.MapEntityToDto).ToList();
            }

            return policies;
        }

        // GET api/people/5
        public Data.DTOs.Policy GetPolicy(int id)
        {
            Data.DTOs.Policy policy;

            using (var ctx = new ContosoInsuranceContext(_connectionString))
            {
                policy = PolicyMapping.MapEntityToDto(ctx.Policies.FirstOrDefault(p => p.Id == id));
            }

            return policy;
        }

    }
}