using System.Collections.Generic;

namespace TrainingPOO.CompositionAndAggregation.Domains
{
    public class Drawers
    {
        public IList<Socks> Socks {get;set;}
        public IList<Briefs> Briefs {get;set;}
    }
}