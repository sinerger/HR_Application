using HR_Application_BLL.Controllers;
using NUnit.Framework;

namespace HR_Application_BLL.Tests
{
    public class CompetenceTest
    {
        [Test]
        public void GetCompetencesByEmployeeID_WhenValidTestPassed_ShouldReturnNewListCompetenceObjects()
        {
            TestCompetenceMapper controller = new TestCompetenceMapper();

            var actual = controller.GetCompetencesByEmployeeID(1);
        }
    }
}