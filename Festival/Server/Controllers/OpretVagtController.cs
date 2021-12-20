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

    public class OpretVagtController : ControllerBase
    {
        private readonly string _connection;
        public OpretVagtController(IConfiguration configuration)
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
        public async Task OpretVagt(Vagter v)
        {

            using (var conne = OpenConnection(_connection))
            {
                //var starttidspunkt = v.starttidspunkt.ToString("yyyy-MM-dd HH:mm:ss");
                //var sluttidspunkt = v.sluttidspunkt.ToString("yyyy-MM-dd HH:mm:ss");
                var query = @"call opret_vagt(@starttidspunkt,@sluttidspunkt,@beskrivelse,@kap,@holdid,@dag)";
                var values = new { starttidspunkt = v.starttidspunkt, sluttidspunkt = v.sluttidspunkt, beskrivelse = v.beskrivelse, kap = v.kap, holdid = v.holdId, dag = v.dag };

                await conne.ExecuteAsync(query, values);
            }
        }
    }



}
