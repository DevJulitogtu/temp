using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Apps.Insurance.Data;
using Contoso.Apps.Insurance.Data.DTOs;

namespace Contoso.Apps.Insurance.Data.Mapping
{
    public static class PolicyMapping
    {
        public static DTOs.Policy MapEntityToDto(Data.Policy source)
        {
            var destination = new DTOs.Policy
            {
                Id = source.Id,
                DefaultDeductible = source.DefaultDeductible,
                DefaultOutOfPocketMax = source.DefaultOutOfPocketMax,
                Description = source.Description,
                Name = source.Name,
                PolicyHolders_Count = source.PolicyHolders.Count
            };

            return destination;
        }

        public static Data.Policy MapDtoToEntity(DTOs.Policy source)
        {
            var destination = new Data.Policy
            {
                Id = source.Id,
                DefaultDeductible = source.DefaultDeductible,
                DefaultOutOfPocketMax = source.DefaultOutOfPocketMax,
                Description = source.Description,
                Name = source.Name
            };

            return destination;
        }
    }
}
