using System;
using Dapper;
using System.Data;
using DiabloDB.Models;
using System.Collections.Generic;

namespace DiabloDB.Data
{
  public class HeroesRepository
  {
    private readonly IDbConnection _db;
    public HeroesRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}