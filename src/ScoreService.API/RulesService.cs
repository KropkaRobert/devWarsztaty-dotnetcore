using System.Collections.Generic;
using System.Linq;
using ScoreService.API.Rules;

namespace ScoreService.API
{
    public  class RulesService
    {
        private readonly List<IRule> rules;

        public RulesService()
        {
            rules = new List<IRule>();
            rules.Add(new IncomeRule());
            rules.Add(new AgeRule());
            rules.Add(new CountryRule());
            rules.Add(new MortgageRule());
        }    

        public bool ValidateAll(ApplicantRequest applicantRequest)
        {
            return rules.All(x=>x.Validate(applicantRequest));
        }
    }
}