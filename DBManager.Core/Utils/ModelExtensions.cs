using System;
using System.Data;

namespace DBManager.Core.Utils
{
    public static class ModelExtensions
    {
        public static T TryConvertTo<T>(this DataRow row, string fieldName)
        {
            T value;

            try
            {
                value = row.Field<T>(fieldName);
            }
            catch (InvalidCastException)
            {
                return default;
            }

            return value;
        }
    }
}
