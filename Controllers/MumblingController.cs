using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExplosiveAPI.Controllers
{
  [Route("/api")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("mumbling/{s}")]
    public string Mumbling(string s)
    {
      s = s.ToLower();
      var accum = "";
      for (var i = 0; i < s.Count(); i++)
      {
        for (var j = 0; j <= i; j++)
        {
          if (j == 0)
          {
            accum += s[i].ToString().ToUpper();
          }
          else
          {
            accum += s[i];
          }
        }
        accum += "-";
      }
      return accum.TrimEnd('-');
    }
  }
}