using System;
using Microsoft.Extensions.Configuration;
using Dapper;
using Npgsql;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using Sem2project.Shared.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Sem2project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FrivilligeController:ControllerBase
    {
        private readonly string _connection;
        public FrivilligeController(IConfiguration configuration)
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
        public async Task<IEnumerable<Bruger>> Get()
        {
            using (var conne = OpenConnection(_connection))
            {
                var query = @"Select * From bruger;";
                var result = await conne.QueryAsync<Bruger>(query);
                return result.ToList();
            }
        }

        
    }


   
    
}
