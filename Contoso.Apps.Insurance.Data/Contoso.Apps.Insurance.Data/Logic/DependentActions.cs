using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Apps.Insurance.Data.Mapping;

namespace Contoso.Apps.Insurance.Data.Logic
{
    public class DependentActions : IDisposable
    {
        private ContosoInsuranceContext _db;

        public DependentActions(string connectionString = null)
        {
            _db = !string.IsNullOrWhiteSpace(connectionString) ? new ContosoInsuranceContext(connectionString) : new ContosoInsuranceContext();
        }

        public Dependent GetDependent(int id)
        {
            return _db.Dependents.FirstOrDefault(p => p.Id == id);
        }

        public IList<Dependent> GetDependentsByPolicyHolder(int policyHolderId)
        {
            var dependents = _db.Dependents.Where(d => d.PolicyHolderId == policyHolderId);
            return dependents.ToList();
        }

        public void SaveDependent(Dependent dependent)
        {
            if (dependent.Id > 0)
            {
                var pModel = _db.Dependents.FirstOrDefault(p => p.Id == dependent.Id);
                if (pModel != null)
                {
                    DependentMapping.CopyPropertiesForUpdate(dependent, ref pModel);
                }
            }
            else
            {
                _db.Dependents.Add(dependent);
            }
            
            _db.SaveChanges();
        }

        public void DeleteDependent(int dependentId)
        {
            var dependent = _db.Dependents.FirstOrDefault(p => p.Id == dependentId);
            if (dependent == null) return;
            // Remove dependent:
            _db.Dependents.Remove(dependent);
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
