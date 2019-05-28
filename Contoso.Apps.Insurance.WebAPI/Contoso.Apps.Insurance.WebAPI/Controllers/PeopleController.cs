﻿using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.Apps.Insurance.WebAPI.Controllers
{
    public class PeopleController : ControllerBase
    {
        private readonly string _connectionString = EncryptionHelper.SecretConnectionString;

        // DELETE api/people/5
        public void DeletePerson(int personId)
        {
            using (var actions = new PersonActions(_connectionString))
            {
                actions.DeletePerson(personId);
            }
        }

        // GET api/people
        public IList<Contoso.Apps.Insurance.Data.DTOs.Person> GetAllPeople(bool getPeopleWhoAreNotPolicyHolders = false)
        {
            List<Contoso.Apps.Insurance.Data.DTOs.Person> people;

            using (var actions = new PersonActions(_connectionString))
            {
                people = getPeopleWhoAreNotPolicyHolders ? actions.GetPeopleWhoAreNotPolicyHolders().Select(PersonMapping.MapEntityToDto).ToList() : actions.GetAllPeople().ToList().Select(PersonMapping.MapEntityToDto).ToList();
            }

            return people;
        }

        // GET api/people/5
        public Contoso.Apps.Insurance.Data.DTOs.Person GetPerson(int id)
        {
            Contoso.Apps.Insurance.Data.DTOs.Person person;

            using (var ctx = new ContosoInsuranceContext(_connectionString))
            {
                person = PersonMapping.MapEntityToDto(ctx.People.FirstOrDefault(p => p.Id == id));
            }

            return person;
        }

        public int SavePerson(Contoso.Apps.Insurance.Data.DTOs.Person person)
        {
            using (var actions = new PersonActions(_connectionString))
            {
                var personModel = PersonMapping.MapDtoToEntity(person);
                actions.SavePerson(personModel);
                person.Id = personModel.Id;
            }
            return person.Id;
        }
    }
}