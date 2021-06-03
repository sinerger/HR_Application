using HR_Application_BLL.Controllers;
using NUnit.Framework;

namespace HR_Application_BLL.Tests
{
    public class CompetenceTest
    {
        [Test]
        public void GetCompetencesByEmployeeID_WhenValidTestPassed_ShouldReturnNewListCompetenceObjects()
        {
            CompetenceController controller = new CompetenceController();

            var actual = controller.GetCompetencesByEmployeeID(1);
        }
    }
}