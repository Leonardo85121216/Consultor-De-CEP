using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace InfosCEP
{

    //Classe responsável por realizar consultas de CEP utilizando a API ViaCEP.

    public class PesquisarCEP
    {
        private readonly HttpClient _httpClient;

        // Construtor da classe PesquisarCEP.
        public PesquisarCEP()
        {
            _httpClient = new HttpClient();
        }


        // Consulta o endereço correspondente ao CEP fornecido utilizando a API ViaCEP.

        public async Task<InfosViaService> ConsultarCEP(string cep)
        {
            // Constrói a URL da API ViaCEP com o CEP fornecido
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            try
            {
                // Realiza uma solicitação GET à API ViaCEP
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                // Verifica se a solicitação foi bem sucedida
                if (response.IsSuccessStatusCode)
                {
                    // Lê e desserializa a resposta JSON
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<InfosViaService>(jsonResponse);
                }
                else
                {
                    // Se a solicitação não foi bem sucedida, lança uma exceção com o código de status HTTP
                    throw new Exception("O CEP FOI DIGITADO INCORRETEMENTE, TENTE NOVAMENTE");
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, lança uma exceção com a mensagem de erro original
                throw new Exception(ex.Message);
            }
        }
    }
}
