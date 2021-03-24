using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace RefitBug.RestFolder
{
    [Binding]
    public sealed class StepDefinition1
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public StepDefinition1(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I run my test")]
        public void GivenIRunMyTest()
        {
            Assert.IsFalse(new WoofClient().GetMyDawg().Result);
        }

    }
}
