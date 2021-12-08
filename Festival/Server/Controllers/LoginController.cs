﻿using System;
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

    public class LoginController : ControllerBase
    {
        private readonly string _connection;
        public LoginController(IConfiguration configuration)
        {
            _connection = configuration.GetConnectionString("Admin");
        }

        public static IDbConnection OpenConnection(string conne)
        {
            var conn = new NpgsqlConnection(conne);
            conn.Open();
            return conn;
        }

        [HttpGet("{em}/{pw}")]
        public async Task<int> GetLogin(string em, string pw)
        {
            using (var conne = OpenConnection(_connection))
            {
                var query = @"select compare_login(@email, @password)";
                var values = new { email = em, password = pw };

                var result = await conne.QueryAsync<int>(query, values);
                return result.First();
            }
        }
    }


    
}
