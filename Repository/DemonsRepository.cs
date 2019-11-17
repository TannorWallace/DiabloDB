using System;
using Dapper;
using System.Data;
using DiabloDB.Models;
using System.Collections.Generic;

namespace DiabloDB.Data
{
  public class DemonsRepository
  {
    private readonly IDbConnection _db;
    public DemonsRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}