using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using PolicyConnectManagementService.DataAccessServiceReference;
using Dependent = Contoso.Apps.Insurance.Data.DTOs.Dependent;
using Person = Contoso.Apps.Insurance.Data.DTOs.Person;
using Policy = Contoso.Apps.Insurance.Data.DTOs.Policy;
using PolicyHolder = Contoso.Apps.Insurance.Data.DTOs.PolicyHolder;

namespace PolicyConnectManagementService
{
    public class PolicyManagementService : IPolicyManagementService
    {
        public IList<Person> GetAllPeople()
        {
            List<Person> result;

            using (var client = GetDataServiceClient())
            {
                result = client
                    .GetAllPeople()
                    .Select(c => new Person
                    {
                        Id = c.Id,
                        Address = c.Address,
                        Address2 = c.Address2,
                        City = c.City,
                        DisplayName = c.DisplayName,
                        Dob = c.Dob,
                        FName = c.FName,
                        LName = c.LName,
                        Postcode = c.Postcode,
                        Suburb = c.Suburb,
                        Dependents = c.Dependents.Select(d => new Dependent
                        {
                            Id = d.Id,
                            Active = d.Active,
                            PersonId = d.PersonId,
                            PolicyHolderId = d.PolicyHolderId,
                            PolicyHolderName = d.PolicyHolderName
                        }).ToList()
                    })
                    .ToList();
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
                var person = client.GetPerson(id);

                result = new Person
                {
                    Address = person.Address,
                    Address2 = person.Address2,
                    City = person.City,
                    DisplayName = person.DisplayName,
                    Dob = person.Dob,
                    FName = person.FName,
                    LName = person.LName,
                    Postcode = person.Postcode,
                    Suburb = person.Suburb,
                    Dependents = person.Dependents.Select(d => new Dependent
                    {
                        Id = d.Id,
                        Active = d.Active,
                        PersonId = d.PersonId,
                        PolicyHolderId = d.PolicyHolderId,
                        PolicyHolderName = d.PolicyHolderName
                    }).ToList()
                };

                client.Close();
            }

            return result;
        }

        public int SavePerson(Person person)
        {
            var id = 0;

            using (var client = GetDataServiceClient())
            {
                id = client.SavePerson(new DataAccessServiceReference.Person
                {
                    Address = person.Address,
                    Address2 = person.Address2,
                    City = person.City,
                    DisplayName = person.DisplayName,
                    Dob = person.Dob,
                    FName = person.FName,
                    LName = person.LName,
                    Postcode = person.Postcode,
                    Suburb = person.Suburb,
                    Dependents = person.Dependents.Select(d => new DataAccessServiceReference.Dependent
                    {
                        Id = d.Id,
                        Active = d.Active,
                        PersonId = d.PersonId,
                        PolicyHolderId = d.PolicyHolderId,
                        PolicyHolderName = d.PolicyHolderName
                    }).ToArray()
                });
                client.Close();
            }

            return id;
        }

        public int SavePolicyHolder(PolicyHolder policyHolder)
        {
            var id = 0;

            using (var client = GetDataServiceClient())
            {
                id = client.SavePolicyHolder(new DataAccessServiceReference.PolicyHolder
                {
                    Id = policyHolder.Id,
                    PersonId = policyHolder.Id,
                    Active = policyHolder.Active,
                    Deductible = policyHolder.Deductible,
                    Dependents_Count = policyHolder.Dependents_Count,
                    EffectiveDate = policyHolder.EffectiveDate,
                    EndDate = policyHolder.EndDate,
                    ExpirationDate = policyHolder.ExpirationDate,
                    FilePath = policyHolder.FilePath,
                    OutOfPocketMax = policyHolder.OutOfPocketMax,
                    PolicyAmount = policyHolder.PolicyAmount,
                    PolicyId = policyHolder.PolicyId,
                    PolicyNumber = policyHolder.PolicyNumber,
                    StartDate = policyHolder.StartDate,
                    Username = policyHolder.Username,
                    Dependents = policyHolder.Dependents.Select(c => new DataAccessServiceReference.Dependent
                    {
                        Id = c.Id,
                        PersonId = c.PersonId,
                        Active = c.Active,
                        PolicyHolderId = c.PolicyHolderId,
                        PolicyHolderName = c.PolicyHolderName
                    }).ToArray()
                });

                client.Close();
            }

            return id;
        }

        public IList<Policy> GetPolicies()
        {
            List<Policy> result;

            using (var client = GetDataServiceClient())
            {
                result = client
                    .GetPolicies()
                    .Select(c => new Policy
                    {
                        Id = c.Id,
                        DefaultDeductible = c.DefaultDeductible,
                        DefaultOutOfPocketMax = c.DefaultOutOfPocketMax,
                        Description = c.Description,
                        Name = c.Name,
                        PolicyHolders_Count = c.PolicyHolders_Count
                    })
                    .ToList();
                client.Close();
            }

            return result;
        }

        public IList<Dependent> GetDependentsByPolicyHolder(int policyHolderId)
        {
            List<Dependent> result;

            using (var client = GetDataServiceClient())
            {
                result = client
                    .GetDependentsByPolicyHolder(policyHolderId)
                    .Select(c => new Dependent
                    {
                        Id = c.Id,
                        PersonId = c.PersonId,
                        Active = c.Active,
                        PolicyHolderId = c.PolicyHolderId,
                        PolicyHolderName = c.PolicyHolderName
                    })
                    .ToList();

                client.Close();
            }

            return result;
        }

        public PolicyHolder GetPolicyHolder(int id)
        {
            PolicyHolder result;

            using (var client = GetDataServiceClient())
            {
                var policyHolder = client.GetPolicyHolder(id);

                result = new PolicyHolder
                {
                    Id = policyHolder.Id,
                    PersonId = policyHolder.Id,
                    Active = policyHolder.Active,
                    Deductible = policyHolder.Deductible,
                    Dependents_Count = policyHolder.Dependents_Count,
                    EffectiveDate = policyHolder.EffectiveDate,
                    EndDate = policyHolder.EndDate,
                    ExpirationDate = policyHolder.ExpirationDate,
                    FilePath = policyHolder.FilePath,
                    OutOfPocketMax = policyHolder.OutOfPocketMax,
                    PolicyAmount = policyHolder.PolicyAmount,
                    PolicyId = policyHolder.PolicyId,
                    PolicyNumber = policyHolder.PolicyNumber,
                    StartDate = policyHolder.StartDate,
                    Username = policyHolder.Username,
                    Dependents = policyHolder.Dependents.Select(c => new Dependent
                    {
                        Id = c.Id,
                        PersonId = c.PersonId,
                        Active = c.Active,
                        PolicyHolderId = c.PolicyHolderId,
                        PolicyHolderName = c.PolicyHolderName
                    }).ToList()
                };

                client.Close();
            }

            return result;
        }

        public IList<PolicyHolder> GetPolicyHolders()
        {
            List<PolicyHolder> result;

            using (var client = GetDataServiceClient())
            {
                result = client
                    .GetPolicyHolders()
                    .Select(c => new PolicyHolder
                    {
                        Id = c.Id,
                        Active = c.Active,
                        Deductible = c.Deductible,
                        Dependents = c.Dependents.Select(d => new Dependent
                        {
                            Id = d.Id,
                            Active = d.Active,
                            PersonId = d.PersonId,
                            PolicyHolderId = d.PolicyHolderId,
                            PolicyHolderName = d.PolicyHolderName
                        }).ToList(),
                        Dependents_Count = c.Dependents_Count,
                        EffectiveDate = c.EffectiveDate,
                        EndDate = c.EndDate,
                        ExpirationDate = c.ExpirationDate,
                        FilePath = c.FilePath,
                        OutOfPocketMax = c.OutOfPocketMax,
                        PersonId = c.PersonId,
                        PolicyAmount = c.PolicyAmount,
                        PolicyId = c.PolicyId,
                        PolicyNumber = c.PolicyNumber,
                        StartDate = c.StartDate,
                        Username = c.Username
                    }).ToList();

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
                result = client
                    .GetPeopleWhoAreNotPolicyHolders()
                    .Select(c => new Person
                    {
                        Id = c.Id,
                        Address = c.Address,
                        Address2 = c.Address2,
                        City = c.City,
                        DisplayName = c.DisplayName,
                        Dob = c.Dob,
                        FName = c.FName,
                        LName = c.LName,
                        Postcode = c.Postcode,
                        Suburb = c.Suburb,
                        Dependents = c.Dependents.Select(d => new Dependent
                        {
                            Id = d.Id,
                            Active = d.Active,
                            PersonId = d.PersonId,
                            PolicyHolderId = d.PolicyHolderId,
                            PolicyHolderName = d.PolicyHolderName
                        }).ToList()
                    })
                    .ToList();

                client.Close();
            }

            return result;
        }

        public Dependent GetDependent(int id)
        {
            Dependent result;

            using (var client = GetDataServiceClient())
            {
                var dependent = client.GetDependent(id);

                result = new Dependent
                {
                    Id = dependent.Id,
                    Active = dependent.Active,
                    PersonId = dependent.PersonId,
                    PolicyHolderId = dependent.PolicyHolderId,
                    PolicyHolderName = dependent.PolicyHolderName
                };

                client.Close();
            }

            return result;
        }

        public int SaveDependent(Dependent dependent)
        {
            var id = 0;

            using (var client = GetDataServiceClient())
            {
                id = client.SaveDependent(new DataAccessServiceReference.Dependent
                {
                    Active = dependent.Active,
                    PersonId = dependent.PersonId,
                    PolicyHolderId = dependent.PolicyHolderId,
                    PolicyHolderName = dependent.PolicyHolderName
                });
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
