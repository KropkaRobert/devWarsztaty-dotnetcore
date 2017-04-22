using System;

namespace ScoreService.API.Rules
{
    public class MortgageRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest)
        {
            return !applicantRequest.Mortgage;
        }
    }
}