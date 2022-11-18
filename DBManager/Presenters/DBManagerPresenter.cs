using DBManager.Core.Dto;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Models;
using System;
using System.Threading.Tasks;

namespace DBManager.Presenters
{
    public class DBManagerPresenter : IDBManagerPresenter
    {
        private readonly DBManagerService _service;

        public DBManagerPresenter(IDBManagerModel model)
        {
            var dataTransferMethods = new DataTransferMethods
            {
                GetConnectionNames = GetConnectionNames,
                GetPresenter = GetPresenter
            };

            _service = new DBManagerService(model, dataTransferMethods);
            _service.InitializeEnginePresenters();
        }

        public async Task<Response> AddConnection(AddConnectionDto dto)
        {
            try
            {
                await _service.AddConnection(dto);
                return Response.Ok();
            }
            catch (Exception exception)
            {
                return Response.Error(exception.Message);
            }
        }

        public Response<PresenterResponseDto> GetPresenter(string connectionName)
        {
            try
            {
                var dto = _service.GetPresenter(connectionName);
                return Response<PresenterResponseDto>.Ok(dto);
            }
            catch (Exception exception)
            {
                return Response<PresenterResponseDto>.Error(exception.Message);
            }
        }

        public async Task<Response> RemoveConnection(string connectionName)
        {
            try
            {
                await _service.RemoveConnection(connectionName);
                return Response.Ok();
            }
            catch (Exception exception)
            {
                return Response.Error(exception.Message);
            }
        }

        public async Task<Response> UpdateConnection(UpdateConnectionDto dto)
        {
            try
            {
                await _service.UpdateConnection(dto);
                return Response.Ok();
            }
            catch (Exception exception)
            {
                return Response.Error(exception.Message);
            }
        }

        public Response<ConnectionNamesResponseDto> GetConnectionNames()
        {
            try
            {
                var dto = _service.GetConnectionNames();
                return Response<ConnectionNamesResponseDto>.Ok(dto);
            }
            catch (Exception exception)
            {
                return Response<ConnectionNamesResponseDto>.Error(exception.Message);
            }
        }

        public Response<AddConnectionDto> GetConnectionSettings(string connectionName)
        {
            try
            {
                var dto = _service.GetConnectionSettings(connectionName);
                return Response<AddConnectionDto>.Ok(dto);
            }
            catch (Exception exception)
            {
                return Response<AddConnectionDto>.Error(exception.Message);
            }
        }
    }
}
