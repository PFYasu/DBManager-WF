﻿using DBManager.Dto;
using DBManager.Models;
using DBManager.Models.Engines;
using DBManager.Presenters.Engines;
using DBManager.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBManager.Presenters
{
    public class DBManagerPresenter : DBManagerPresenterBase
    {
        private readonly IDBManagerModel _model;
        private readonly Dictionary<string, EnginePresenterBase> _presenters;

        public DBManagerPresenter(IDBManagerModel model)
        {
            _model = model;
            _presenters = new Dictionary<string, EnginePresenterBase>();
        }

        public override async Task<Response> AddConnection(AddConnectionDto dto)
        {
            List<string> names;

            try
            {
                names = _model.GetConnectionNames();
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            if (names.Contains(dto.Name))
                return Error($"Connection with {dto.Name} already exists");

            var parameters = dto.ConnectionParameters;

            string connectionString = ConnectorHelper.Combine(parameters);

            var connection = new Connection
            {
                Name = dto.Name,
                Type = dto.Type,
                ConnectionString = connectionString
            };

            try
            {
                await _model.AddConnection(connection);
                await _model.LoadConnections();
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            return Ok();
        }

        public override Response GetPresenter(string connectionName)
        {
            List<string> names;

            PresenterResponseDto dto;
            EnginePresenterBase presenter;

            if (_presenters.TryGetValue(connectionName, out EnginePresenterBase presenterFromDictionary))
            {
                dto = new PresenterResponseDto
                {
                    Type = presenterFromDictionary.EngineType,
                    Presenter = presenterFromDictionary
                };

                return Ok(dto);
            }

            try
            {
                names = _model.GetConnectionNames();
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            if (names.Contains(connectionName) == false)
                return Error($"Connection with {connectionName} does not exist.");

            Connection connection;

            try
            {
                connection = _model.GetConnection(connectionName);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            EngineType type;
            IEngineModel model;

            switch (connection.Type)
            {
                case EngineType.MySql:
                    type = connection.Type;
                    model = new MySqlModel(connection);
                    presenter = new MySqlPresenter(model, this);
                    break;
                default:
                    return Error("Unable to create presenter. Incorrect engine type.");
            }

            dto = new PresenterResponseDto
            {
                Type = type,
                Presenter = presenter
            };

            if (_presenters.TryAdd(connectionName, presenter) == false)
            {
                return Error($"Connection {connectionName} already exists in dictionary.");
            }

            return Ok(dto);
        }

        public override async Task<Response> RemoveConnection(string connectionName)
        {
            List<string> names;

            try
            {
                names = _model.GetConnectionNames();
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            if (names.Contains(connectionName) == false)
                return Error($"Connection with {connectionName} does not exist.");

            try
            {
                await _model.RemoveConnection(connectionName);
                await _model.LoadConnections();
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            _presenters.Remove(connectionName);

            return Ok();
        }

        public override Response GetConnectionNames()
        {
            List<string> names;

            try
            {
                names = _model.GetConnectionNames();
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var dto = new ConnectionNamesDto { Names = names };

            return Ok(dto);
        }
    }
}