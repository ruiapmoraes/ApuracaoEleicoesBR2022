using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface ICandidatoService
    {
         Task<Cand> CheckUrlApuracaoAsync(string seq, string sqcand, string n, string nn, string cc, 
             string nv, string e, string st, string dvt, string vap, string pvap);

        Task<List<Cand>> CheckUrlAsync(string url, string requestId);
    }
}
