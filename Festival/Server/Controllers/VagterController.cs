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

    public class VagterController : ControllerBase
    {
        private readonly string _connection;
        public VagterController(IConfiguration configuration)
        {
            _connection = configuration.GetConnectionString("Admin");

        }

        public static IDbConnection OpenConnection(string conne)
        {
            var conn = new NpgsqlConnection(conne);
            conn.Open();
            return conn;
        }

        [HttpGet]
        public async Task<IEnumerable<Vagter>> GetVagter()
        {
            using (var conne = OpenConnection(_connection))
            {
                var query = @"Select * From vagter;";
                var result = await conne.QueryAsync<Vagter>(query);
                return result.ToList();
            }
        }
    }
}
