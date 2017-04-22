using System;

namespace ScoreService.API.Rules
{
    public class AgeRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest)
        {
            if (applicantRequest.Age >= 21)
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