using System.Collections.Generic;
using System.Linq;
using Contoso.Apps.Insurance.Data;
using Contoso.Apps.Insurance.Data.Logic;
using Contoso.Apps.Insurance.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Policy = Contoso.Apps.Insurance.Data.DTOs.Policy;
using PolicyHolder = Contoso.Apps.Insurance.Data.DTOs.PolicyHolder;

namespace PolicyConnectDataService
{
    public class DataAccessService : IDataAccessService
    {
        public void DeleteDependent(int dependentId)
        {
            using (var actions = new DependentActions())
            {
                actions.DeleteDependent(dependentId);
            }
        }

        public void DeletePerson(int personId)
        {
            using (var actions = new PersonActions())
            {
                actions.DeletePerson(personId);
            }
        }

        public void DeletePolicyHolder(int policyHolderId)
        {
            using (var actions = new PolicyActions())
            {
                actions.DeletePolicyHolder(policyHolderId);
            }
        }

        public IList<Contoso.Apps.Insurance.Data.DTOs.Person> GetAllPeople()
        {
            List<Contoso.Apps.Insurance.Data.DTOs.Person> people;

            using (var ctx = new ContosoInsuranceContext())
            {
                people = ctx.People.OrderBy(p => p.LName).ToList().Select(PersonMapping.MapEntityToDto).ToList();
            }

            return people;
        }

        public string GetData(int value)
        {
            return $"You entered: {value}";
        }

        public Contoso.Apps.Insurance.Data.DTOs.Dependent GetDependent(int id)
        {
            Contoso.Apps.Insurance.Data.DTOs.Dependent dependent;

            using (var ctx = new ContosoInsuranceContext())
            {
                dependent = DependentMapping.MapEntityToDto(ctx.Dependents.FirstOrDefault(p => p.Id == id));
            }

            return dependent;
        }

        public IList<Contoso.Apps.Insurance.Data.DTOs.Dependent> GetDependentsByPolicyHolder(int policyHolderId)
        {
            List<Contoso.Apps.Insurance.Data.DTOs.Dependent> dependents;

            using (var actions = new DependentActions())
            {
                dependents = actions.GetDependentsByPolicyHolder(policyHolderId).Select(DependentMapping.MapEntityToDto).ToList();
            }

            return dependents;
        }

        public IList<Contoso.Apps.Insurance.Data.DTOs.Person> GetPeopleWhoAreNotPolicyHolders()
        {
            List<Contoso.Apps.Insurance.Data.DTOs.Person> people;

            using (var actions = new PersonActions())
            {
                people = actions.GetPeopleWhoAreNotPolicyHolders().Select(PersonMapping.MapEntityToDto).ToList();
            }

            return people;
        }

        public Contoso.Apps.Insurance.Data.DTOs.Person GetPerson(int id)
        {
            Contoso.Apps.Insurance.Data.DTOs.Person person;

            using (var ctx = new ContosoInsuranceContext())
            {
                person = PersonMapping.MapEntityToDto(ctx.People.FirstOrDefault(p => p.Id == id));
            }

            return person;
        }

        public IList<Contoso.Apps.Insurance.Data.DTOs.Policy> GetPolicies()
        {
            List<Policy> policies;

            using (var ctx = new ContosoInsuranceContext())
            {
                policies = ctx.Policies.ToList().Select(PolicyMapping.MapEntityToDto).ToList();
            }

            return policies;
        }

        public PolicyHolder GetPolicyHolder(int id)
        {
            PolicyHolder policyHolder;

            using (var ctx = new ContosoInsuranceContext())
            {
                var policyHolderData = ctx.PolicyHolders.Include(p => p.Policy)
                    .Include(p => p.Person).Include(p => p.Dependents).FirstOrDefault(p => p.Id == id);
                policyHolder = PolicyHolderMapping.MapEntityToDto(policyHolderData);
            }

            return policyHolder;
        }

        public IList<Contoso.Apps.Insurance.Data.DTOs.PolicyHolder> GetPolicyHolders()
        {
            List<PolicyHolder> policies;

            using (var ctx = new ContosoInsuranceContext())
            {
                var policyHolders = ctx.PolicyHolders.Include(p => p.Policy).Include(p => p.Person)
                    .Include(p => p.Dependents).OrderBy(p => p.Person.LName).ToList();
                policies = policyHolders.Select(PolicyHolderMapping.MapEntityToDto).ToList();
            }

            return policies;
        }

        public int SaveDependent(Contoso.Apps.Insurance.Data.DTOs.Dependent dependent)
        {
            using (var actions = new DependentActions())
            {
                var dependentModel = DependentMapping.MapDtoToEntity(dependent);
                actions.SaveDependent(dependentModel);
                dependent.Id = dependentModel.Id;
            }
            return dependent.Id;
        }

        public int SavePerson(Contoso.Apps.Insurance.Data.DTOs.Person person)
        {
            using (var actions = new PersonActions())
            {
                var personModel = PersonMapping.MapDtoToEntity(person);
                actions.SavePerson(personModel);
                person.Id = personModel.Id;
            }
            return person.Id;
        }

        public int SavePolicyHolder(PolicyHolder policyHolder)
        {
            using (var actions = new PolicyActions())
            {
                var policyHolderModel = PolicyHolderMapping.MapDtoToEntity(policyHolder);
                actions.SavePolicyHolder(policyHolderModel);
                policyHolder.Id = policyHolderModel.Id;
            }
            return policyHolder.Id;
        }
    }
}
