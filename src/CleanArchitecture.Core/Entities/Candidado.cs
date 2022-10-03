using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Entities
{
    public class Candidado
    {
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Cand : BaseEntity
    {
        public string seq { get; set; }
        public string sqcand { get; set; }
        public string n { get; set; }
        public string nm { get; set; }
        public string cc { get; set; }
        public string nv { get; set; }
        public string e { get; set; }
        public string st { get; set; }
        public string dvt { get; set; }
        public string vap { get; set; }
        public string pvap { get; set; }
    }

    public class CandidatoRoot
    {
        public string ele { get; set; }
        public string tpabr { get; set; }
        public string cdabr { get; set; }
        public string carper { get; set; }
        public string md { get; set; }
        public string t { get; set; }
        public string f { get; set; }
        public string dg { get; set; }
        public string hg { get; set; }
        public string dt { get; set; }
        public string ht { get; set; }
        public string dv { get; set; }
        public string tf { get; set; }
        public string v { get; set; }
        public string esae { get; set; }
        public string mnae { get; set; }
        public string s { get; set; }
        public string st { get; set; }
        public string pst { get; set; }
        public string snt { get; set; }
        public string psnt { get; set; }
        public string si { get; set; }
        public string psi { get; set; }
        public string sni { get; set; }
        public string psni { get; set; }
        public string sa { get; set; }
        public string psa { get; set; }
        public string sna { get; set; }
        public string psna { get; set; }
        public string e { get; set; }
        public string ea { get; set; }
        public string pea { get; set; }
        public string ena { get; set; }
        public string pena { get; set; }
        public string esi { get; set; }
        public string pesi { get; set; }
        public string esni { get; set; }
        public string pesni { get; set; }
        public string c { get; set; }
        public string pc { get; set; }
        public string a { get; set; }
        public string pa { get; set; }
        public string vscv { get; set; }
        public string vnom { get; set; }
        public string pvnom { get; set; }
        public string vvc { get; set; }
        public string pvvc { get; set; }
        public string vb { get; set; }
        public string pvb { get; set; }
        public string tvn { get; set; }
        public string ptvn { get; set; }
        public string vn { get; set; }
        public string pvn { get; set; }
        public string vnt { get; set; }
        public string pvnt { get; set; }
        public string vp { get; set; }
        public string pvp { get; set; }
        public string vv { get; set; }
        public string pvv { get; set; }
        public string van { get; set; }
        public string pvan { get; set; }
        public string vansj { get; set; }
        public string pvansj { get; set; }
        public string tv { get; set; }
        public List<Cand> cand { get; set; }
    }



}
