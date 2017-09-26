using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Locations.DataAccess.EF
{
  public static class ClearingHelper
  {
    public static void ClearRange<TContext, TDbSet>(this TContext contextIn, DbSet<TDbSet> dbSet) where TContext : DbContext where TDbSet : class
    {
      using (var context = contextIn)
      {
        dbSet.RemoveRange(dbSet);
      }
    }

    public static void ResetIdentity<T>(this T contextIn, string tableName) where T : DbContext
    {
      using (var context = contextIn)
      {
        context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('{tableName}', RESEED, 0)");
      }
    }
  }
}