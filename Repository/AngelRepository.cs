using System;
using Dapper;
using System.Data;
using DiabloDB.Models;
using System.Collections.Generic;

namespace DiabloDB.Data
{
  public class AngelRepository
  {
    private readonly IDbConnection _db;
    public AngelRepository(IDbConnection db)
    {
      _db = db;
    }


  }
}
