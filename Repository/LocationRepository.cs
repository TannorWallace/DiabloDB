using System;
using Dapper;
using System.Data;
using DiabloDB.Models;
using System.Collections.Generic;

namespace DiabloDB.Data
{
  public class LocationRepository
  {
    private readonly IDbConnection _db;

    public LocationRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}