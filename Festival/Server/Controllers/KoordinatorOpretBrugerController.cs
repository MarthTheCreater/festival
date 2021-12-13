using System;
using Microsoft.Extensions.Configuration;
using Dapper;
using Npgsql;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using Festival.Shared.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;


namespace Festival.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class KoordinatorOpretBrugerController : ControllerBase
    {
        private readonly string _connection;
        public KoordinatorOpretBrugerController(IConfiguration configuration)
        {
            _connection = configuration.GetConnectionString("Admin");
        }

        public static IDbConnection OpenConnection(string conne)
        {
            var conn = new NpgsqlConnection(conne);
            conn.Open();
            return conn;
        }

        [HttpGet("{hid}/{pw}/{plvl}")]
        public async Task<ActionResult<int>> GetLogin(int hid, string pw, string plvl)
        {
            try
            {
                using (var conne = OpenConnection(_connection))
                {
                    var query = @"select opret_frillig(@holdId,@powerlvl,@password)";
                    var values = new { holdId = hid, powerlvl = plvl, password = pw };

                    var result = await conne.QueryAsync<int>(query, values);
                    return Ok(result.First());
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }



}
