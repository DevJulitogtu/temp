using Contoso.Apps.Insurance.Data.DTOs;
using Contoso.Apps.Insurance.Data.ViewModels;
using Newtonsoft.Json;
using PolicyConnectDesktop.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicyConnectDesktop.DataMethods
{
    public class WebApiCalls : IServiceCalls
    {
        public static string RootWebApiPath => System.Configuration.ConfigurationManager.AppSettings["RootWebApiPath"];
        readonly IAuthenticationService _AuthenticationService;

        public WebApiCalls(IAuthenticationService authService)
        {
            _AuthenticationService = authService;
        }

        #region Authentication

        public bool CheckAuthentication()
        {
            return _AuthenticationService.IsAuthenticated;
        }

        private async Task<AuthenticationHeaderValue> GetAuthenticationHeader()
        {
            var authResult = _AuthenticationService.AuthenticationResult;
            return new AuthenticationHeaderValue(authResult.AccessTokenType, authResult.AccessToken);
        }
        #endregion

        #region PolicyHolder Methods

        public async Task<List<PolicyHolderViewModel>> GetPolicyHolders()
        {
            Cursor.Current = Cursors.WaitCursor;
            var policyHolders = new List<PolicyHolderViewModel>();
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    using (var response = await client.GetAsync($"{RootWebApiPath}/Api/PolicyHolders/"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            policyHolders = JsonConvert.DeserializeObject<PolicyHolderViewModel[]>(value).ToList();
                        }
                    }
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

        public async Task<PolicyHolder> GetPolicyHolder(int id)
        {
            Cursor.Current = Cursors.WaitCursor;
            var policyHolder = new PolicyHolder();
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    if (id > 0)
                    {
                        using (var response = await client.GetAsync($"{RootWebApiPath}/Api/PolicyHolders/{id}"))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var value = await response.Content.ReadAsStringAsync();

                                policyHolder = JsonConvert.DeserializeObject<PolicyHolder>(value);
                            }
                        }
                    }
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

        public async Task<int> SavePolicyHolder(PolicyHolder policyHolder)
        {
            Cursor.Current = Cursors.WaitCursor;
            var id = 0;
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    var serialized = JsonConvert.SerializeObject(policyHolder);
                    var content = new StringContent(serialized, Encoding.UTF8, "application/json");
                    
                    using (var response = await client.PostAsync($"{RootWebApiPath}/Api/PolicyHolders", content))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            int.TryParse(value, out id);
                        }
                    }
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
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    await client.DeleteAsync($"{RootWebApiPath}/Api/PolicyHolders?dependentId={policyHolderId}");
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
        public async Task<List<Policy>> GetPolicies()
        {
            Cursor.Current = Cursors.WaitCursor;
            var policies = new List<Policy>();
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    using (var response = await client.GetAsync($"{RootWebApiPath}/Api/Policies/"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            policies = JsonConvert.DeserializeObject<Policy[]>(value).ToList();
                        }
                    }
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
        public async Task<List<Person>> GetPeople()
        {
            Cursor.Current = Cursors.WaitCursor;
            var people = new List<Person>();
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    using (var response = await client.GetAsync($"{RootWebApiPath}/Api/People?getPeopleWhoAreNotPolicyHolders=false"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            people = JsonConvert.DeserializeObject<Person[]>(value).ToList();
                        }
                    }
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

        public async Task<List<Person>> GetPeopleWhoAreNotPolicyHolders()
        {
            Cursor.Current = Cursors.WaitCursor;
            var people = new List<Person>();
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    using (var response = await client.GetAsync($"{RootWebApiPath}/Api/People?getPeopleWhoAreNotPolicyHolders=true"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            people = JsonConvert.DeserializeObject<Person[]>(value).ToList();
                        }
                    }
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

        public async Task<Person> GetPerson(int id)
        {
            Cursor.Current = Cursors.WaitCursor;
            var person = new Person();
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    using (var response = await client.GetAsync($"{RootWebApiPath}/Api/People/{id}"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            person = JsonConvert.DeserializeObject<Person>(value);
                        }
                    }
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

        public async Task<int> SavePerson(Person person)
        {
            Cursor.Current = Cursors.WaitCursor;
            var id = 0;
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    var serialized = JsonConvert.SerializeObject(person);
                    var content = new StringContent(serialized, Encoding.UTF8, "application/json");

                    using (var response = await client.PostAsync($"{RootWebApiPath}/Api/People", content))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            int.TryParse(value, out id);
                        }
                    }
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
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    await client.DeleteAsync($"{RootWebApiPath}/Api/People?dependentId={personId}");
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
        public async Task<Dependent> GetDependent(int id)
        {
            Cursor.Current = Cursors.WaitCursor;
            var dependent = new Dependent();
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    if (id > 0)
                    {
                        using (var response = await client.GetAsync($"{RootWebApiPath}/Api/Dependents/{id}"))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var value = await response.Content.ReadAsStringAsync();

                                dependent = JsonConvert.DeserializeObject<Dependent>(value);
                            }
                        }
                    }
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

        public async Task<List<Dependent>> GetDependentsByPolicyHolder(int policyHolderId)
        {
            Cursor.Current = Cursors.WaitCursor;
            var dependents = new List<Dependent>();
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    using (var response = await client.GetAsync($"{RootWebApiPath}/Api/Dependents?policyHolderId={policyHolderId}"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            dependents = JsonConvert.DeserializeObject<Dependent[]>(value).ToList();
                        }
                    }
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

        public async Task<int> SaveDependent(Dependent dependent)
        {
            Cursor.Current = Cursors.WaitCursor;
            var id = 0;
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    var serialized = JsonConvert.SerializeObject(dependent);
                    var content = new StringContent(serialized, Encoding.UTF8, "application/json");

                    using (var response = await client.PostAsync($"{RootWebApiPath}/Api/Dependents/", content))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            int.TryParse(value, out id);
                        }
                    }
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
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    await client.DeleteAsync($"{RootWebApiPath}/Api/Dependents?dependentId={dependentId}");
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
