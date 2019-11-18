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
    public Angels CreateAngels(Angels angels)
    {
      int id = _db.ExecuteScalar<int>
      (@"INSERT INTO angels (img, name, title, history) VALUES (@Img, @Name, @Title, @History); SELECT_LAST_INSERT_ID();", angels);
      angels.Id = id;
      return angels;
    }

    public IEnumerable<Angels> GetAllAngels()
    {
      try
      {
        return _db.Query<Angels>("SELECT * FROM angels");
      }
      catch (Exception e)
      {
        throw new Exception(e.Message);
      }
    }

    public Angels GetAngelsById(int id)
    {
      try
      {
        return _db.QuerySingle<Angels>("SELECT * FROM angels WHERE id = @id", new { id });
      }
      catch (Exception e)
      {

        throw new Exception(e.Message);
      }
    }

    public bool DeleteAngelsById(int id)
    {
      var complete = _db.Execute("DELETE FROM angels WHERE id = @id", new { id });
      return complete > 0;
      {
        throw new Exception("The Heavens Weep");
      }
    }
  }
}
