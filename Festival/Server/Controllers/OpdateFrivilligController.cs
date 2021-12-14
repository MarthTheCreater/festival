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

        [HttpPost]
        public async Task OpdateFrivillige(Bruger b)
        {

            using (var conne = OpenConnection(_connection))
            {
                var query = @"call opdate_frillig(@navn,@tlf,@email,@password)";
                var values = new { navn = b.navn, tlf = b.tlf, email = b.email, password = b.password };

                await conne.ExecuteAsync(query, values);
            }
        }
    }



}
