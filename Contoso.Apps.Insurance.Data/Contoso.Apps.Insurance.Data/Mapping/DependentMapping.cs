using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Apps.Insurance.Data.Mapping
{
    public static class DependentMapping
    {
        public static DTOs.Dependent MapEntityToDto(Data.Dependent source)
        {
            var destination = new DTOs.Dependent
            {
                Id = source.Id,
                Active = source.Active,
                PersonId = source.PersonId,
                PolicyHolderId = source.PolicyHolderId,
                PolicyHolderName = $"{source.PolicyHolder?.Person?.LName}, {source.PolicyHolder?.Person?.FName}"
            };

            //if (source.PolicyHolder != null)
            //{
            //    destination.PolicyHolder = PolicyHolderMapping.MapEntityToDto(source.PolicyHolder);
            //}

            if (source.Person != null)
            {
                destination.Person = PersonMapping.MapEntityToDto(source.Person);
            }

            return destination;
        }

        public static Data.Dependent MapDtoToEntity(DTOs.Dependent source)
        {
            var destination = new Data.Dependent
            {
                Id = source.Id,
                Active = source.Active,
                PersonId = source.PersonId,
                PolicyHolderId = source.PolicyHolderId
            };

            //if (source.PolicyHolder != null)
            //{
            //    destination.PolicyHolder = PolicyHolderMapping.MapDtoToEntity(source.PolicyHolder);
            //}

            if (source.Person != null)
            {
                destination.Person = PersonMapping.MapDtoToEntity(source.Person);
            }

            return destination;
        }

        /// <summary>
        /// Copies properties from the source to the destination object in order to
        /// save the source object's values to the database.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public static void CopyPropertiesForUpdate(Dependent source, ref Dependent destination)
        {
            destination.Active = source.Active;
            destination.PersonId = source.PersonId;
            destination.PolicyHolderId = source.PolicyHolderId;
        }
    }
}
