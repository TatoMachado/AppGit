using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AppGit.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace AppGit.Services
{
    public class GitService
    {
        private string GetUsers = Startup.AppSettings.GetValue<string>("Github:GetUsers");
        private string CodeSearch = Startup.AppSettings.GetValue<string>("Github:CodeSearch");
        private string Events = Startup.AppSettings.GetValue<string>("Github:Events");
        private string RepoUrl = Startup.AppSettings.GetValue<string>("Github:RepoUrl");
        private string TokenBasicLogin = Startup.AppSettings.GetValue<string>("Github:TokenBasicLogin");
        private string TokenBasic = Startup.AppSettings.GetValue<string>("Github:TokenBasic");
        private string Zen = Startup.AppSettings.GetValue<string>("Github:TokenBasicLogin");

        public async Task<User> GetUser(string jsonUser)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenBasic);
            client.DefaultRequestHeaders.Add("User-Agent", "C# App");

            try
            {
                var stringContent = new StringContent(jsonUser, Encoding.UTF8, "application/json");
                var response = await client.GetAsync(GetUsers+jsonUser);
                var responseString = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject(responseString).ToString();
                var result = JsonConvert.DeserializeObject<User>(jsonResult);

                //var stringContent = new StringContent(jsonAluno, Encoding.UTF8, "application/json");
                //var response = await client.PostAsync(urlGravarDiploma, stringContent);
                //var responseString = await response.Content.ReadAsStringAsync();
                //var jsonResult = JsonConvert.DeserializeObject(responseString).ToString();
                //var result = JsonConvert.DeserializeObject<GravarDiplomaResult>(jsonResult);

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Search> GetRepos(String language)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenBasic);
            client.DefaultRequestHeaders.Add("User-Agent", "C# App");

            try
            {
                //var stringContent = new StringContent(language, Encoding.UTF8, "application/json");
                var response = await client.GetAsync(CodeSearch + language.ToString());
                var responseString = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject(responseString).ToString();
                var result = JsonConvert.DeserializeObject<Search>(jsonResult);

                //var stringContent = new StringContent(jsonAluno, Encoding.UTF8, "application/json");
                //var response = await client.PostAsync(urlGravarDiploma, stringContent);
                //var responseString = await response.Content.ReadAsStringAsync();
                //var jsonResult = JsonConvert.DeserializeObject(responseString).ToString();
                //var result = JsonConvert.DeserializeObject<GravarDiplomaResult>(jsonResult);

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
