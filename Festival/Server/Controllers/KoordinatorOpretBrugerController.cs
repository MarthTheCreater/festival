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

        [HttpPost]
        public async Task OpretFrivillig(Bruger b)
        {
           
                using (var conne = OpenConnection(_connection))
                {
                    var query = @"call oprettelse_frivillig(@holdId,@password,@powerlvl)";
                    var values = new { holdId = b.holdId, password = b.password, powerlvl = b.powerlvl };

                    await conne.ExecuteAsync(query, values);
                }
        }
    }
}
