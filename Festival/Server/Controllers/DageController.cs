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

    public class RollerController : ControllerBase
    {
        private readonly string _connection;
        public RollerController(IConfiguration configuration)
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
        public async Task<IEnumerable<Roller>> GetHold()
        {
            using (var conne = OpenConnection(_connection))
            {
                var query = @"Select * From roller;";
                var result = await conne.QueryAsync<Roller>(query);
                return result.ToList();
            }
        }

    }
}
