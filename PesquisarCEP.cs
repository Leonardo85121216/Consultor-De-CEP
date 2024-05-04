using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;



namespace InfosCEP
{
    public class PesquisarCEP
    {
        private readonly HttpClient _httpClient;

        public PesquisarCEP()
        {
            _httpClient = new HttpClient();
        }

        public async Task<InfosViaService> ConsultarCEP(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if(response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<InfosViaService>(jsonResponse);
                }
                else
                {
                    throw new Exception($"Erro ao fazer a solicitação: {response.StatusCode}");
                }

            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
