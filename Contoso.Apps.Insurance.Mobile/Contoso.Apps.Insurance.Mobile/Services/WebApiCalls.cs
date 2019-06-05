using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIMobile.Models;
using CIMobile.Services;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using CIMobile.Models.Local;

[assembly: Dependency(typeof(WebApiCalls))]

namespace CIMobile.Services
{
    public class WebApiCalls : IServiceCalls
    {
        public static string RootWebApiPath => ApplicationSettings.RootWebApiPath;
        readonly IAuthenticationService _AuthenticationService;

        public WebApiCalls()
        {
            _AuthenticationService = DependencyService.Get<IAuthenticationService>();
        }

        #region Authentication

        private async Task<AuthenticationHeaderValue> GetAuthenticationHeader()
        {
            var authResult = _AuthenticationService.AuthenticationResult;

            return new AuthenticationHeaderValue(authResult.AccessTokenType, authResult.AccessToken);
        }
        #endregion

        #region Search Methods
        public async Task<List<Value>> SearchForPdf(string policyNumber)
        {
            var result = new List<Value>();
            using (var client = new HttpClient())
            {
                try
                {
                    var searchUrl = ApplicationSettings.AzureSearchServiceUrl;
                    var apiKey = ApplicationSettings.AzureSearchQueryApiKey;
                    if (searchUrl.Contains("&search=*"))
                        searchUrl = searchUrl.Replace("&search=*", "&search=");

                    var request = new HttpRequestMessage
                    {
                        RequestUri = new Uri($"{searchUrl}{policyNumber}*"),
                        Method = HttpMethod.Get
                    };

                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    request.Headers.Add("api-key", apiKey);

                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            var searchResult = JsonConvert.DeserializeObject<SearchResult>(value);
                            result = searchResult.value.ToList();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }

            return result;
        }
        #endregion

        #region PolicyHolder Methods
        public async Task<List<PolicyHolderViewModel>> GetPolicyHolders()
        {
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
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }

            return policyHolders;
        }

        public async Task<PolicyHolder> GetPolicyHolder(int id)
        {
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
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }

            return policyHolder;
        }

        public async Task<int> SavePolicyHolder(PolicyHolder policyHolder)
        {
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
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }

            return id;
        }

        public async void DeletePolicyHolder(int policyHolderId)
        {
            if (policyHolderId <= 0) return;
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    await client.DeleteAsync($"{RootWebApiPath}/Api/PolicyHolders?dependentId={policyHolderId}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }
        }
        #endregion

        #region Policy Methods
        public async Task<List<Policy>> GetPolicies()
        {
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
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }

            return policies;
        }
        #endregion

        #region Person Methods
        public async Task<List<Person>> GetPeople()
        {
            var people = new List<Person>();
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    using (var response = await client.GetAsync(new Uri($"{RootWebApiPath}/Api/People?getPeopleWhoAreNotPolicyHolders=false")))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var value = await response.Content.ReadAsStringAsync();

                            people = JsonConvert.DeserializeObject<Person[]>(value).ToList();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }
            return people;
        }

        public async Task<List<Person>> GetPeopleWhoAreNotPolicyHolders()
        {
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
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }
            return people;
        }

        public async Task<Person> GetPerson(int id)
        {
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
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }

            return person;
        }

        public async Task<int> SavePerson(Person person)
        {
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
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }

            return id;
        }

        public async void DeletePerson(int personId)
        {
            if (personId <= 0) return;
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    await client.DeleteAsync($"{RootWebApiPath}/Api/People?dependentId={personId}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }
        }
        #endregion

        #region Dependent Methods
        public async Task<Dependent> GetDependent(int id)
        {
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
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }

            return dependent;
        }

        public async Task<List<Dependent>> GetDependentsByPolicyHolder(int policyHolderId)
        {
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
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }

            return dependents;
        }

        public async Task<int> SaveDependent(Dependent dependent)
        {
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
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }

            return id;
        }

        public async void DeleteDependent(int dependentId)
        {
            if (dependentId <= 0) return;
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = await GetAuthenticationHeader();
                    await client.DeleteAsync($"{RootWebApiPath}/Api/Dependents?dependentId={dependentId}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred while communicating with the server: {ex.Message}");
                }
            }
        }
        #endregion
    }
}
