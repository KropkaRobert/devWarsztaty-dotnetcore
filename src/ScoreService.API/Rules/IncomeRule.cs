using System;

namespace ScoreService.API.Rules
{
    public class IncomeRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest)
        {
            if (applicantRequest.Income > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}