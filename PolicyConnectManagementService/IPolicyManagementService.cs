using System.Collections.Generic;
using System.ServiceModel;
using Contoso.Apps.Insurance.Data.DTOs;

namespace PolicyConnectManagementService
{
    [ServiceContract]
    public interface IPolicyManagementService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string Ping();

        [OperationContract]
        IList<Person> GetAllPeople();

        [OperationContract]
        IList<Person> GetPeopleWhoAreNotPolicyHolders();

        [OperationContract]
        IList<PolicyHolder> GetPolicyHolders();

        [OperationContract]
        IList<Policy> GetPolicies();

        [OperationContract]
        PolicyHolder GetPolicyHolder(int id);

        [OperationContract]
        Person GetPerson(int id);

        [OperationContract]
        Dependent GetDependent(int id);

        [OperationContract]
        IList<Dependent> GetDependentsByPolicyHolder(int policyHolderId);

        [OperationContract]
        int SavePerson(Person person);

        [OperationContract]
        int SavePolicyHolder(PolicyHolder policyHolder);

        [OperationContract]
        int SaveDependent(Dependent dependent);

        [OperationContract]
        void DeletePerson(int personId);

        [OperationContract]
        void DeleteDependent(int dependentId);

        [OperationContract]
        void DeletePolicyHolder(int policyHolderId);
    }
}


