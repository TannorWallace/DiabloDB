using System;
using Dapper;
using System.Data;
using DiabloDB.Models;
using System.Collections.Generic;

namespace DiabloDB.Data
{
  public class NephilemRepository
  {
    private readonly IDbConnection _db;
    public NephilemRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}