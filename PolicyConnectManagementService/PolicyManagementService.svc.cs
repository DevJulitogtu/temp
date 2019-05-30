using System.Collections.Generic;
using System.Configuration;
using Contoso.Apps.Insurance.Data.DTOs;

namespace PolicyConnectManagementService
{
    public class PolicyManagementService : IPolicyManagementService
    {

        public IList<Person> GetAllPeople()
        {
            List<Person> result;

            using (var client = GetDataServiceClient())
            {
                result = client.GetAllPeople().ToList();
                client.Close();
            }

            return result;
        }

        public string GetData(int value)
        {
            var result = "";
            //var authCon = ServiceSecurityContext.Current.AuthorizationContext;
            using (var client = GetDataServiceClient())
            {
                result = client.GetData(value + 5);
                client.Close();
            }

            return $"You entered: {value}. {value} + 5 = {result}";
        }

        public Person GetPerson(int id)
        {
            Person result;

            using (var client = GetDataServiceClient())
            {
                result = client.GetPerson(id);
                client.Close();
            }

            return result;
        }

        public int SavePerson(Person person)
        {
            var id = 0;

            using (var client = GetDataServiceClient())
            {
                id = client.SavePerson(person);
                client.Close();
            }

            return id;
        }

        public int SavePolicyHolder(PolicyHolder policyHolder)
        {
            var id = 0;

            using (var client = GetDataServiceClient())
            {
                id = client.SavePolicyHolder(policyHolder);
                client.Close();
            }

            return id;
        }

        public IList<Policy> GetPolicies()
        {
            List<Policy> result;

            using (var client = GetDataServiceClient())
            {
                result = client.GetPolicies().ToList();
                client.Close();
            }

            return result;
        }

        public IList<Dependent> GetDependentsByPolicyHolder(int policyHolderId)
        {
            List<Dependent> result;

            using (var client = GetDataServiceClient())
            {
                result = client.GetDependentsByPolicyHolder(policyHolderId).ToList();
                client.Close();
            }

            return result;
        }

        public PolicyHolder GetPolicyHolder(int id)
        {
            PolicyHolder result;

            using (var client = GetDataServiceClient())
            {
                result = client.GetPolicyHolder(id);
                client.Close();
            }

            return result;
        }

        public IList<PolicyHolder> GetPolicyHolders()
        {
            List<PolicyHolder> result;

            using (var client = GetDataServiceClient())
            {
                result = client.GetPolicyHolders().ToList();
                client.Close();
            }

            return result;
        }

        public string Ping()
        {
            return "Pong";
        }

        private DataAccessServiceClient GetDataServiceClient()
        {
            var dataAccessServiceClient = new DataAccessServiceClient();
            dataAccessServiceClient.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["DataServiceUsername"];
            dataAccessServiceClient.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["DataServicePassword"];
            return dataAccessServiceClient;
        }

        public IList<Person> GetPeopleWhoAreNotPolicyHolders()
        {
            List<Person> result;

            using (var client = GetDataServiceClient())
            {
                result = client.GetPeopleWhoAreNotPolicyHolders().ToList();
                client.Close();
            }

            return result;
        }

        public Dependent GetDependent(int id)
        {
            Dependent result;

            using (var client = GetDataServiceClient())
            {
                result = client.GetDependent(id);
                client.Close();
            }

            return result;
        }

        public int SaveDependent(Dependent dependent)
        {
            var id = 0;

            using (var client = GetDataServiceClient())
            {
                id = client.SaveDependent(dependent);
                client.Close();
            }

            return id;
        }

        public void DeletePerson(int personId)
        {
            using (var client = GetDataServiceClient())
            {
                client.DeletePerson(personId);
                client.Close();
            }
        }

        public void DeleteDependent(int dependentId)
        {
            using (var client = GetDataServiceClient())
            {
                client.DeleteDependent(dependentId);
                client.Close();
            }
        }

        public void DeletePolicyHolder(int policyHolderId)
        {
            using (var client = GetDataServiceClient())
            {
                client.DeletePolicyHolder(policyHolderId);
                client.Close();
            }
        }
    }
}
