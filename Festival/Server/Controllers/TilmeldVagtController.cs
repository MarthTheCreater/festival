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

    public class TilmeldVagtController : ControllerBase
    {
        private readonly string _connection;
        public TilmeldVagtController(IConfiguration configuration)
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
        public async Task TilmeldVagt(Vagter v)
        {

            using (var conne = OpenConnection(_connection))
            {
                var query = @"call tilmeld_vagt(@id,@dag,@starttidspunkt,@sluttidspunkt,@beskrivelse)";
                var values = new {id = v.vagterId, dag = v.dag, starttidspunkt = v.starttidspunkt, sluttidspunkt = v.sluttidspunkt, beskrivelse = v.beskrivelse};

                await conne.ExecuteAsync(query, values);
            }
        }
    }



}
