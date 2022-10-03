using Ardalis.GuardClauses;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly IHttpService _httpService;
        public CandidatoService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public Task<Cand> CheckUrlApuracaoAsync(string seq, string sqcand, string n, string nn, string cc, string nv, string e, string st, string dvt, string vap, string pvap)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cand>> CheckUrlAsync(string url, string requestId)
        {

            using (WebClient wc = new WebClient())
            {

                Guard.Against.NullOrWhiteSpace(url, nameof(url));

                var statusCode = await _httpService.GetUrlResponseStatusCodeAsync(url);
                var json = wc.DownloadString(url);

                CandidatoRoot myDeserializedClass = JsonConvert.DeserializeObject<CandidatoRoot>(json);
                List<Cand> apuracao = new List<Cand>();

                if (myDeserializedClass != null)
                {
                    foreach (var candidato in myDeserializedClass.cand)
                    {
                        apuracao.Add(candidato);
                    }
                }
                return apuracao;
            }           
        }
    }
}
