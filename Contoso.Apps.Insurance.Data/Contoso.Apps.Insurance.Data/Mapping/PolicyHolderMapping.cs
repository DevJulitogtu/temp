using System.Linq;
using Contoso.Apps.Insurance.Data.ViewModels;

namespace Contoso.Apps.Insurance.Data.Mapping
{
    public static class PolicyHolderMapping
    {
        public static DTOs.PolicyHolder MapEntityToDto(PolicyHolder source)
        {
            var destination = new DTOs.PolicyHolder
            {
                Id = source.Id,
                Active = source.Active,
                Deductible = source.Deductible,
                EffectiveDate = source.EffectiveDate,
                EndDate = source.EndDate,
                ExpirationDate = source.ExpirationDate,
                FilePath = source.FilePath,
                OutOfPocketMax = source.OutOfPocketMax,
                PersonId = source.PersonId,
                PolicyAmount = source.PolicyAmount,
                PolicyId = source.PolicyId,
                PolicyNumber = source.PolicyNumber,
                StartDate = source.StartDate,
                Username = source.Username,
                Dependents_Count = source.Dependents.Count
            };

            if (source.Dependents.Any())
            {
                foreach (var dependent in source.Dependents)
                {
                    destination.Dependents.Add(DependentMapping.MapEntityToDto(dependent));
                }
            }

            if (source.Policy != null)
            {
                destination.Policy = PolicyMapping.MapEntityToDto(source.Policy);
            }

            if (source.Person != null)
            {
                destination.Person = PersonMapping.MapEntityToDto(source.Person);
            }

            return destination;
        }

        public static PolicyHolder MapDtoToEntity(DTOs.PolicyHolder source)
        {
            var destination = new PolicyHolder
            {
                Id = source.Id,
                Active = source.Active,
                Deductible = source.Deductible,
                EffectiveDate = source.EffectiveDate,
                EndDate = source.EndDate,
                ExpirationDate = source.ExpirationDate,
                FilePath = source.FilePath,
                OutOfPocketMax = source.OutOfPocketMax,
                PersonId = source.PersonId,
                PolicyAmount = source.PolicyAmount,
                PolicyId = source.PolicyId,
                PolicyNumber = source.PolicyNumber,
                StartDate = source.StartDate,
                Username = source.Username
            };

            if (source.Dependents.Any())
            {
                foreach (var dependent in source.Dependents)
                {
                    destination.Dependents.Add(DependentMapping.MapDtoToEntity(dependent));
                }
            }

            if (source.Policy != null)
            {
                destination.Policy = PolicyMapping.MapDtoToEntity(source.Policy);
            }

            if (source.Person != null)
            {
                destination.Person = PersonMapping.MapDtoToEntity(source.Person);
            }

            return destination;
        }

        public static PolicyHolderViewModel MapDtoToViewModel(DTOs.PolicyHolder source)
        {
            var destination = new PolicyHolderViewModel
            {
                Id = source.Id,
                Active = source.Active,
                Deductible = source.Deductible,
                EffectiveDate = source.EffectiveDate,
                ExpirationDate = source.ExpirationDate,
                FName = source.Person.FName,
                LName = source.Person.LName,
                OutOfPocketMax = source.OutOfPocketMax,
                Policy = source.Policy.Name,
                PolicyAmount = source.PolicyAmount,
                PolicyNumber = source.PolicyNumber,
                PolicyId = source.PolicyId,
                PersonId = source.PersonId,
                PersonDisplayName = $"{source.Person.LName}, {source.Person.FName}",
                Dependents_Count = source.Dependents_Count
            };

            return destination;
        }

        public static PolicyHolderViewModel MapEntityToViewModel(PolicyHolder source)
        {
            var destination = new PolicyHolderViewModel
            {
                Id = source.Id,
                Active = source.Active,
                Deductible = source.Deductible,
                EffectiveDate = source.EffectiveDate,
                ExpirationDate = source.ExpirationDate,
                FName = source.Person.FName,
                LName = source.Person.LName,
                OutOfPocketMax = source.OutOfPocketMax,
                Policy = source.Policy.Name,
                PolicyAmount = source.PolicyAmount,
                PolicyNumber = source.PolicyNumber,
                PolicyId = source.PolicyId,
                PersonId = source.PersonId,
                PersonDisplayName = $"{source.Person.LName}, {source.Person.FName}",
                Dependents_Count = source.Dependents.Count
            };

            return destination;
        }

        /// <summary>
        /// Copies properties from the source to the destination object in order to
        /// save the source object's values to the database.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public static void CopyPropertiesForUpdate(PolicyHolder source, ref PolicyHolder destination)
        {
            destination.Active = source.Active;
            destination.Deductible = source.Deductible;
            destination.EffectiveDate = source.EffectiveDate;
            destination.EndDate = source.EndDate;
            destination.ExpirationDate = source.ExpirationDate;
            destination.FilePath = source.FilePath;
            destination.OutOfPocketMax = source.OutOfPocketMax;
            destination.PersonId = source.PersonId;
            destination.PolicyAmount = source.PolicyAmount;
            destination.PolicyId = source.PolicyId;
            destination.PolicyNumber = source.PolicyNumber;
            destination.StartDate = source.StartDate;
            destination.Username = source.Username;
        }
    }
}
