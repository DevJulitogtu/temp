using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contoso.Apps.Insurance.Data.DTOs;
using Contoso.Apps.Insurance.Data.Mapping;
using Contoso.Apps.Insurance.Data.ViewModels;
using PolicyConnectDesktop.PolicyManagementServiceReference;
using Dependent = Contoso.Apps.Insurance.Data.DTOs.Dependent;
using PolicyHolder = PolicyConnectDesktop.PolicyManagementServiceReference.PolicyHolder;

namespace PolicyConnectDesktop.DataMethods
{
    public class WcfCalls : IServiceCalls
    {
        /// <summary>
        /// Returns a new instance of the PolicyManagement Service Client.
        /// </summary>
        /// <returns></returns>
        private PolicyManagementServiceClient GetPolicyManagementServiceClient()
        {
            var dataAccessServiceClient = new PolicyManagementServiceClient();
            dataAccessServiceClient.ClientCredentials.UserName.UserName = Authentication.AuthenticationMethods.Username;
            dataAccessServiceClient.ClientCredentials.UserName.Password = Authentication.AuthenticationMethods.Password;
            return dataAccessServiceClient;
        }

        #region Authentication

        public bool CheckAuthentication()
        {
            Cursor.Current = Cursors.WaitCursor;
            var isAuthenticated = false;
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    var result = client.Ping();
                    if (!string.IsNullOrWhiteSpace(result))
                    {
                        isAuthenticated = true;
                    }
                }
                catch (MessageSecurityException mex)
                {
                    isAuthenticated = false;
                    //MessageBox.Show("Authentication failed. Please log in.");
                }
                catch (System.ServiceModel.CommunicationObjectFaultedException comex)
                {
                    isAuthenticated = false;
                }
                catch (Exception ex)
                {
                    isAuthenticated = false;
                    //MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            return isAuthenticated;
        }
        #endregion

        #region ThisPolicyHolder Methods

        public async Task<List<PolicyHolderViewModel>> GetPolicyHolders()
        {
            Cursor.Current = Cursors.WaitCursor;
            var policyHolders = new List<PolicyHolderViewModel>();
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    var policyHoldersDto = client
                        .GetPolicyHolders()
                        .Select(c => new Contoso.Apps.Insurance.Data.DTOs.PolicyHolder
                        {
                            Id = c.Id,
                            Active = c.Active,
                            Deductible = c.Deductible,
                            Dependents = c.Dependents.Select(d => new Dependent
                            {
                                Id = d.Id,
                                Active = d.Active,
                                PersonId = d.PersonId,
                                PolicyHolderId = d.PolicyHolderId
                            }).ToList(),
                            Dependents_Count = c.Dependents.Length,
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
                        })
                        .ToList();


                    policyHolders = policyHoldersDto.Select(PolicyHolderMapping.MapDtoToViewModel).ToList();
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }

            return policyHolders;
        }

        public async Task<Contoso.Apps.Insurance.Data.DTOs.PolicyHolder> GetPolicyHolder(int id)
        {
            Cursor.Current = Cursors.WaitCursor;
            var policyHolder = new Contoso.Apps.Insurance.Data.DTOs.PolicyHolder();
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    if (id > 0) policyHolder = client.GetPolicyHolder(id);
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }

            return policyHolder;
        }

        public async Task<int> SavePolicyHolder(Contoso.Apps.Insurance.Data.DTOs.PolicyHolder policyHolder)
        {
            Cursor.Current = Cursors.WaitCursor;
            var id = 0;
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    id = client.SavePolicyHolder(policyHolder);
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }

            return id;
        }

        public async void DeletePolicyHolder(int policyHolderId)
        {
            if (policyHolderId <= 0) return;
            Cursor.Current = Cursors.WaitCursor;
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    client.DeletePolicyHolder(policyHolderId);
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        #endregion

        #region Policy Methods
        public async Task<List<Contoso.Apps.Insurance.Data.DTOs.Policy>> GetPolicies()
        {
            Cursor.Current = Cursors.WaitCursor;
            var policies = new List<Contoso.Apps.Insurance.Data.DTOs.Policy>();
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    policies = client
                        .GetPolicies()
                        .Select(c => new Contoso.Apps.Insurance.Data.DTOs.Policy
                        {
                            Id = c.Id,
                            DefaultDeductible = c.DefaultDeductible,
                            DefaultOutOfPocketMax = c.DefaultOutOfPocketMax,
                            Description = c.Description,
                            Name = c.Name
                        })
                        .ToList();
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }

            return policies;
        }
        #endregion

        #region Person Methods
        public async Task<List<Contoso.Apps.Insurance.Data.DTOs.Person>> GetPeople()
        {
            Cursor.Current = Cursors.WaitCursor;
            var people = new List<Contoso.Apps.Insurance.Data.DTOs.Person>();
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    people = client.GetAllPeople().ToList();
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            return people;
        }

        public async Task<List<Contoso.Apps.Insurance.Data.DTOs.Person>> GetPeopleWhoAreNotPolicyHolders()
        {
            Cursor.Current = Cursors.WaitCursor;
            var people = new List<Contoso.Apps.Insurance.Data.DTOs.Person>();
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    people = client.GetPeopleWhoAreNotPolicyHolders().ToList();
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            return people;
        }

        public async Task<Contoso.Apps.Insurance.Data.DTOs.Person> GetPerson(int id)
        {
            Cursor.Current = Cursors.WaitCursor;
            var person = new Contoso.Apps.Insurance.Data.DTOs.Person();
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    person = client.GetPerson(id);
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }

            return person;
        }

        public async Task<int> SavePerson(Contoso.Apps.Insurance.Data.DTOs.Person person)
        {
            Cursor.Current = Cursors.WaitCursor;
            var id = 0;
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    id = client.SavePerson(person);
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }

            return id;
        }

        public async void DeletePerson(int personId)
        {
            if (personId <= 0) return;
            Cursor.Current = Cursors.WaitCursor;
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    client.DeletePerson(personId);
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        #endregion

        #region Dependent Methods
        public async Task<Contoso.Apps.Insurance.Data.DTOs.Dependent> GetDependent(int id)
        {
            Cursor.Current = Cursors.WaitCursor;
            var dependent = new Contoso.Apps.Insurance.Data.DTOs.Dependent();
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    if (id > 0) dependent = client.GetDependent(id);
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }

            return dependent;
        }

        public async Task<List<Contoso.Apps.Insurance.Data.DTOs.Dependent>> GetDependentsByPolicyHolder(int policyHolderId)
        {
            Cursor.Current = Cursors.WaitCursor;
            var dependents = new List<Contoso.Apps.Insurance.Data.DTOs.Dependent>();
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    dependents = client.GetDependentsByPolicyHolder(policyHolderId).ToList();
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }

            return dependents;
        }

        public async Task<int> SaveDependent(Contoso.Apps.Insurance.Data.DTOs.Dependent dependent)
        {
            Cursor.Current = Cursors.WaitCursor;
            var id = 0;
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    id = client.SaveDependent(dependent);
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }

            return id;
        }

        public async void DeleteDependent(int dependentId)
        {
            if (dependentId <= 0) return;
            Cursor.Current = Cursors.WaitCursor;
            using (var client = GetPolicyManagementServiceClient())
            {
                try
                {
                    client.DeleteDependent(dependentId);
                }
                catch (MessageSecurityException mex)
                {
                    MessageBox.Show("Your username or password was incorrect. Please try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while communicating with the server: {ex.Message}");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        #endregion
    }
}
