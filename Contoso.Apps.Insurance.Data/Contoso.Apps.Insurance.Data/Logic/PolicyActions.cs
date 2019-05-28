using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Apps.Insurance.Data.Mapping;

namespace Contoso.Apps.Insurance.Data.Logic
{
    public class PolicyActions : IDisposable
    {
        private ContosoInsuranceContext _db;

        public PolicyActions(string connectionString = null)
        {
            _db = !string.IsNullOrWhiteSpace(connectionString) ? new ContosoInsuranceContext(connectionString) : new ContosoInsuranceContext();
        }

        public IList<Policy> GetAllPolicies()
        {
            var policies = _db.Policies.ToList();
            return policies;
        }

        public PolicyHolder GetPolicyForPerson(int id)
        {
            var policy = new PolicyHolder();

            // Retrieve the policy for the passed in person.
            if (_db.PolicyHolders.Any(p => p.PersonId == id))
            {
                policy = _db.PolicyHolders.Include(p => p.Policy).Include(p => p.Person)
                    .Include(p => p.Dependents).Single(ph => ph.PersonId == id);
            }

            return policy;
        }

        public void SavePolicyHolder(PolicyHolder policyHolder)
        {
            try
            {
                if (policyHolder.Id > 0)
                {
                    var ph = _db.PolicyHolders.FirstOrDefault(p => p.Id == policyHolder.Id);
                    if (ph != null)
                    {
                        PolicyHolderMapping.CopyPropertiesForUpdate(policyHolder, ref ph);
                    }
                }
                else
                {
                    _db.PolicyHolders.Add(policyHolder);
                }

                _db.SaveChanges();
            }
            catch (DbEntityValidationException dev)
            {
                throw;
            }
        }

        public void DeletePolicyHolder(int policyHolderId)
        {
            var policyHolder = _db.PolicyHolders.FirstOrDefault(p => p.Id == policyHolderId);
            if (policyHolder == null) return;
            if (policyHolder.Dependents.Count > 0)
            {
                // Remove any dependents:
                _db.Dependents.RemoveRange(policyHolder.Dependents);
            }
            // Remove policy holder:
            _db.PolicyHolders.Remove(policyHolder);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db == null) return;
            _db.Dispose();
            _db = null;
        }
    }
}
