using DBManager.Core.Utils;
using Xunit;

namespace DBManager.Tests.UtilsTests
{
    public class QueryTypeResolver
    {
        [Theory]
        [InlineData("SELECT * FROM database;")]
        [InlineData("select * from database;")]
        [InlineData("SELECT * from database;")]
        [InlineData("select * FROM database;")]
        [InlineData("SELECT firstName, lastName\n FROM employees where Age < 30;")]
        public void ForQuery_WithSelectStatement_ReturnsQueryType(string query)
        {
            var result = Act(query);


            Assert.Equal(QueryType.Query, result);
        }

        [Theory]
        [InlineData("UPDATE employees SET salary = 3000 WHERE salary < 2500;")]
        [InlineData("UPDATE employees SET selection = 2 WHERE selection = 1;")]
        [InlineData("Update selectTable set fromColumn = 'test' WHERE fromColumn = 'otherTest';")]
        [InlineData("Update selectTable\n set fromColumn = 'test'\n WHERE fromColumn = 'otherTest';")]
        public void ForNonQuery_WithUpdateStatement_ReturnsNonQueryType(string query)
        {
            var result = Act(query);


            Assert.Equal(QueryType.NonQuery, result);
        }

        [Theory]
        [InlineData("INSERT INTO test (`ID`, `Age`) VALUES ('id1', 23);")]
        [InlineData("INSERT INTO selectTable VALUES (1, 2, 3);")]
        [InlineData("INSERT INTO selectTable\n VALUES (1, 2, 3);")]
        public void ForNonQuery_WithInsertStatement_ReturnsNonQueryType(string query)
        {
            var result = Act(query);


            Assert.Equal(QueryType.NonQuery, result);
        }

        [Theory]
        [InlineData("DELETE FROM selectTable WHERE fromColumn < 5;")]
        [InlineData("DELETE FROM fromTable WHERE selectColumn = 5 AND select_FromDb = 3;")]
        [InlineData("DELETE FROM fromTable \nWHERE selectColumn = 5 AND select_FromDb = 3;")]
        public void ForNonQuery_WithDeleteStatement_ReturnsNonQueryType(string query)
        {
            var result = Act(query);


            Assert.Equal(QueryType.NonQuery, result);
        }


        public QueryType Act(string query)
        {
            var result = Core.Utils.QueryTypeResolver.GetQueryType(query);

            return result;
        }
    }
}
