using System;
using Dapper;
using System.Data;
using DiabloDB.Models;
using System.Collections.Generic;

namespace DiabloDB.Data
{
  public class OtherDietiesRepository
  {
    private readonly IDbConnection _db;
    public OtherDietiesRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}