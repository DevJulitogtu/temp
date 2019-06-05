using System.Collections.Generic;
using System.Threading.Tasks;
using CIMobile.Models;
using CIMobile.Models.Local;

namespace CIMobile.Services
{
    public interface IServiceCalls
    {

        Task<List<Value>> SearchForPdf(string policyNumber);

        Task<List<PolicyHolderViewModel>> GetPolicyHolders();

        Task<PolicyHolder> GetPolicyHolder(int id);

        Task<int> SavePolicyHolder(PolicyHolder policyHolder);

        void DeletePolicyHolder(int policyHolderId);

        Task<List<Policy>> GetPolicies();

        Task<List<Person>> GetPeople();

        Task<List<Person>> GetPeopleWhoAreNotPolicyHolders();

        Task<Person> GetPerson(int id);

        Task<int> SavePerson(Person person);

        void DeletePerson(int personId);

        Task<Dependent> GetDependent(int id);

        Task<List<Dependent>> GetDependentsByPolicyHolder(int policyHolderId);

        Task<int> SaveDependent(Dependent dependent);

        void DeleteDependent(int dependentId);

    }
}