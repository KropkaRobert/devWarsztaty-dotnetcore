using System;
using ScoreService.API;
using ScoreService.API.Rules;
using Xunit;

namespace ScoreService.Tests
{
    public class RulesTests
    {
        [Fact]
        public void GivenValidateWhenIncomeLessThan10000()
        {
            //arrange
            var incomeRule = new IncomeRule();

            var applicantRequest = new ApplicantRequest
            {
                Income = 9000
            };

            //act
            var result = incomeRule.Validate(applicantRequest);

            //assert
            Assert.False(result);
        }
    }
}
