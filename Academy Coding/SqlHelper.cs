using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AcademyCoding
{
    public static class SqlHelper
    {
        private static Dictionary<Type, SqlDbType> _typeMap;
        static SqlHelper()
        {
            _typeMap = new Dictionary<Type, SqlDbType>();

            _typeMap[typeof(string)] = SqlDbType.NVarChar;
            _typeMap[typeof(char[])] = SqlDbType.NVarChar;
            _typeMap[typeof(byte)] = SqlDbType.TinyInt;
            _typeMap[typeof(short)] = SqlDbType.SmallInt;
            _typeMap[typeof(int)] = SqlDbType.Int;
            _typeMap[typeof(long)] = SqlDbType.BigInt;
            _typeMap[typeof(byte[])] = SqlDbType.Image;
            _typeMap[typeof(bool)] = SqlDbType.Bit;
            _typeMap[typeof(DateTime)] = SqlDbType.DateTime2;
            _typeMap[typeof(DateTimeOffset)] = SqlDbType.DateTimeOffset;
            _typeMap[typeof(decimal)] = SqlDbType.Money;
            _typeMap[typeof(float)] = SqlDbType.Real;
            _typeMap[typeof(double)] = SqlDbType.Float;
            _typeMap[typeof(TimeSpan)] = SqlDbType.Time;

        }
        public static SqlDbType GetDbType(Type giveType)
        {
            giveType = Nullable.GetUnderlyingType(giveType) ?? giveType;

            if (_typeMap.ContainsKey(giveType))
            {
                return _typeMap[giveType];
            }

            throw new ArgumentException($"{giveType.FullName} is not a supported .NET class");
        }
    }
}
