using System.Linq;
using Locations.DataAccess.EF;
using Locations.DataAccess.EF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Locations.Tests.DataAccess
{
  [TestClass]
  public class BusinessContextTests
  {
    [TestMethod]
    public void CanGenerateSeeding()
    {
      //Assign
      List<Business> businesses = new List<Business>();

      //Act
      using (var context = new BusinessesContext())
      {
        businesses = context.Business.ToList();
      }

      //Assert
      Assert.AreEqual(2, businesses.Count, "There should be two businesses from seeding");
    }
  }
}
