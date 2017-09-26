using Locations.DataAccess.EF.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Locations.DataAccess.EF
{
  public class BusinessDbInitializer : DropCreateDatabaseAlways<BusinessesContext>
  {
    protected override void Seed(BusinessesContext context)
    {
      IList<Business> businesses = new List<Business>
      {
          new Business
          {
            BusinessName = "Thriftway",
            Locations = new List<Location>
            {
              new Location
              {
                LocationName = "Bales Garden Home",
                Address = "7680 SW Garden Home Rd.",
                City = "Portland",
                State = "OR",
                Zip = 97223,
                Latitude = 1,
                Longitude = 1,
                Orders = new List<Order>
                {
                  new Order { OrderDescription = "Lawnmower", Amount = 200}
                }
              }
            }
          }
          , new Business
          {
            BusinessName = "Fred Meyer",
            Locations = new List<Location>
            {
              new Location
              {
                LocationName = "SW 99",
                Address = "8900 SW 99th",
                City = "Portland",
                State = "OR",
                Zip = 97223,
                Latitude = 2,
                Longitude = 2,
                Orders = new List<Order>
                {
                  new Order { OrderDescription = "Groceries", Amount = 160},
                  new Order { OrderDescription = "Clothes", Amount = 40},
                  new Order { OrderDescription = "Electronics", Amount = 500}
                }
              }
            }
          }
      };

      foreach (var biz in businesses)
        context.Business.Add(biz);

      base.Seed(context);
    }
  }
}