using System;
using Dapper;
using System.Data;
using DiabloDB.Models;
using System.Collections.Generic;

namespace DiabloDB.Data
{
  public class LegendaryItemRepository
  {
    private readonly IDbConnection _db;
    public LegendaryItemRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}