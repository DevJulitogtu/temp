using System;
using System.Collections.Generic;
using System.Linq;
using Contoso.Apps.Insurance.Data.Mapping;

namespace Contoso.Apps.Insurance.Data.Logic
{
    public class PersonActions : IDisposable
    {
        private ContosoInsuranceContext _db;

        public PersonActions(string connectionString = null)
        {
            _db = !string.IsNullOrWhiteSpace(connectionString) ? new ContosoInsuranceContext(connectionString) : new ContosoInsuranceContext();
        }

        public IList<Person> GetAllPeople()
        {
            var people = _db.People.OrderBy(p => p.LName).ToList();
            return people;
        }

        public IList<Person> GetPeopleWhoAreNotPolicyHolders()
        {
            var people = from peeps in _db.People
                where peeps.PolicyHolders.Count == 0
                orderby peeps.LName select peeps;
            return people.ToList();
        }

        public Person GetPerson(int id)
        {
            return _db.People.FirstOrDefault(p => p.Id == id);
        }

        public void SavePerson(Person person)
        {
            if (person.Id > 0)
            {
                var pModel = _db.People.FirstOrDefault(p => p.Id == person.Id);
                if (pModel != null)
                {
                    PersonMapping.CopyPropertiesForUpdate(person, ref pModel);
                }
            }
            else
            {
                _db.People.Add(person);
            }
            
            _db.SaveChanges();
        }

        public void DeletePerson(int personId)
        {
            var person = _db.People.FirstOrDefault(p => p.Id == personId);
            if (person == null) return;
            // Remove person:
            _db.People.Remove(person);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db == null) return;
            _db.Dispose();
            _db = null;
        }
    }
}
