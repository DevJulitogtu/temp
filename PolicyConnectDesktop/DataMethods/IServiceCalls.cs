using System.Collections.Generic;
using System.Threading.Tasks;
using Contoso.Apps.Insurance.Data.DTOs;
using Contoso.Apps.Insurance.Data.ViewModels;

namespace PolicyConnectDesktop.DataMethods
{
    public interface IServiceCalls
    {
        bool CheckAuthentication();
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