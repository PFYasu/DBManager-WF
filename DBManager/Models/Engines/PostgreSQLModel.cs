﻿using DBManager.Utils;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DBManager.Models.Engines
{
    public class PostgreSQLModel : IEngineModel
    {
        private readonly string _connectionString;

        public PostgreSQLModel(Connection connection)
        {
            var connectionParameters = connection.ConnectionParameters;
            _connectionString = ConnectorHelper.Combine(connectionParameters);

            Name = connection.Name;
            Type = connection.Type;
            ConnectionParameters = connectionParameters;
        }

        public string Name { get; }
        public EngineType Type { get; }
        public Dictionary<string, string> ConnectionParameters { get; }

        public async Task<DataTable> ExecuteQuery(string query)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();

            var dataTable = StartExecuteQuery(connection, query);

            await connection.CloseAsync();
            return dataTable;
        }

        public async Task<DataTable> ExecuteQuery(string query, string databaseName)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();

            connection.ChangeDatabase(databaseName);

            var dataTable = StartExecuteQuery(connection, query);

            await connection.CloseAsync();
            return dataTable;
        }

        public async Task<int> ExecuteNonQuery(string query)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();

            var affected = await StartExecuteNonQuery(connection, query);

            await connection.CloseAsync();
            return affected;
        }

        public async Task<int> ExecuteNonQuery(string query, string databaseName)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();

            connection.ChangeDatabase(databaseName);

            var affected = await StartExecuteNonQuery(connection, query);

            await connection.CloseAsync();
            return affected;
        }

        private DataTable StartExecuteQuery(NpgsqlConnection connection, string query)
        {
            using var command = new NpgsqlCommand(query, connection);
            using var dataAdapter = new NpgsqlDataAdapter(command);

            var dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        private async Task<int> StartExecuteNonQuery(NpgsqlConnection connection, string query)
        {
            var command = new NpgsqlCommand(query, connection);
            var affected = await command.ExecuteNonQueryAsync();

            return affected;
        }
    }
}