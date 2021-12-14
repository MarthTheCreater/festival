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


        [HttpPost]
        public async Task OpretBruger(Bruger b)
        {

            using (var conne = OpenConnection(_connection))
            {
                var query = @"call opret_frivillige(@navn,@email,@tlf,@password)";
                var values = new { navn = b.navn, email = b.email, tlf = b.tlf, password = b.password };

                await conne.ExecuteAsync(query, values);
            }
        }
    }



}
