using DBManager.Dto.Engines;
using DBManager.Models;
using DBManager.Models.Engines;
using System;
using System.Collections.Generic;

namespace DBManager.Presenters.Engines
{
    public class QueryTrackerDriver : QueryTrackerDriverBase
    {
        private readonly IEngineModel _model;

        public QueryTrackerDriver(IEngineModel model)
        {
            _model = model;
        }

        public override Response GetTrackedQueryNames(string databaseName)
        {
            List<string> names;

            try
            {
                names = _model.QueryTracker.GetTrackedQueryNames(databaseName);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var dto = new TrackedQueryNamesResponseDto { Names = names };

            return Ok(dto);
        }

        public override Response AddTrackedQuery(NewTrackedQueryDto dto)
        {
            if (TrackedQueryExists(dto.Name, dto.DatabaseName))
                return Error($"Tracked query with {dto.Name} name already exists");

            var trackedQuery = new TrackedQuery(dto.Name, dto.DatabaseName, dto.Query, dto.TimePeriod);

            try
            {
                _model.QueryTracker.AddTrackedQuery(trackedQuery);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            return Ok();
        }

        public override Response RemoveTrackedQuery(string name, string databaseName)
        {
            if (TrackedQueryExists(name, databaseName) == false)
                return Error($"Tracked query with {name} name does not exist");

            try
            {
                _model.QueryTracker.RemoveTrackedQuery(name, databaseName);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            return Ok();
        }

        public override Response GetTrackedQuery(string name, string databaseName)
        {
            if (TrackedQueryExists(name, databaseName) == false)
                return Error($"Tracked query with {name} name does not exist");

            TrackedQuery result;

            try
            {
                result = _model.QueryTracker.GetTrackedQuery(name, databaseName);
            }
            catch (Exception exception)
            {
                return Error(exception.Message);
            }

            var dto = new TrackedQueryResponseDto
            {
                TrackedQuery = result
            };

            return Ok(dto);
        }

        private bool TrackedQueryExists(string name, string databaseName)
        {
            List<string> names;

            try
            {
                names = _model.QueryTracker.GetTrackedQueryNames(databaseName);
            }
            catch (Exception)
            {
                return false;
            }

            return names.Contains(name);
        }
    }
}
