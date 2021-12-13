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

    public class OpdateFrivilligController : ControllerBase
    {
        private readonly string _connection;
        public OpdateFrivilligController(IConfiguration configuration)
        {
            _connection = configuration.GetConnectionString("Admin");
        }

        public static IDbConnection OpenConnection(string conne)
        {
            var conn = new NpgsqlConnection(conne);
            conn.Open();
            return conn;
        }

        [HttpGet("{n}/{tlf}/{em}/{pw}")]
        public async Task<ActionResult<int>> GetLogin(string n, int tlf, string em, string pw)
        {

            using (var conne = OpenConnection(_connection))
            {
                var query = @"select opdate_frillig(@navn,@tlf,@email,@password)";
                var values = new { navn = n, tlf = tlf, email = em, password = pw };

                var result = await conne.QueryAsync<int>(query, values);
                return Ok(result);
            }

        }
    }



}
