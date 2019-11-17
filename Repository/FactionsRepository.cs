using System;
using Dapper;
using System.Data;
using DiabloDB.Models;
using System.Collections.Generic;

namespace DiabloDB.Data
{
  public class FactionsRepository
  {
    private readonly IDbConnection _db;

    public FactionsRepository(IDbConnection db)
    {
      _db = db;
    }
  }

}