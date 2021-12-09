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

    public class OpretBrugerController : ControllerBase
    {
        private readonly string _connection;
        public OpretBrugerController(IConfiguration configuration)
        {
            _connection = configuration.GetConnectionString("Admin");
        }

        public static IDbConnection OpenConnection(string conne)
        {
            var conn = new NpgsqlConnection(conne);
            conn.Open();
            return conn;
        }

        [HttpGet("{n}/{em}/{tlf}/{pw}/{aid}")]
        public async Task<ActionResult<int>> GetLogin(int aid, string n, string em, string pw, int tlf)
        {
            try
            {
                using (var conne = OpenConnection(_connection))
                {
                    var query = @"select opret_frillig(@adgangsID,@navn,@email,@password,@telefonnummer)";
                    var values = new { adgangsID = aid, navn = n, email = em, password = pw, telefonnummer = tlf };

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
