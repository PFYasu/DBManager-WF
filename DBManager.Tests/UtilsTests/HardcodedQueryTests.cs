using DBManager.Utils;
using System.Collections.Generic;
using Xunit;

namespace DBManager.Tests.UtilsTests
{
    public class HardcodedQueryTests
    {
        [Fact]
        public void SelectStatementShouldBeCorrect_ForSpecificDatabase()
        {
            const string tableName = "Employees";
            var columns = new List<string>
            {
                "LastName",
                "FirstName",
                "Age"
            };

            const string correctSelectStatement = "SELECT\r\nLastName, FirstName, Age \r\nFROM Employees;";


            var result = QueryHelper.HardcodedQuery.Select(tableName, columns);


            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(correctSelectStatement, result);
        }

        [Fact]
        public void InsertIntoStatementShouldBeCorrect_ForSpecificDatabase()
        {
            const string tableName = "Employees";
            var columns = new List<string>
            {
                "LastName",
                "FirstName",
                "Age"
            };

            const string correctInsertIntoStatement = "INSERT INTO Employees\r\n(LastName, FirstName, Age )\r\nVALUES\r\n(expression0, expression1, expression2 );";


            var result = QueryHelper.HardcodedQuery.InsertInto(tableName, columns);


            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(correctInsertIntoStatement, result);
        }

        [Fact]
        public void DeleteStatementShouldBeCorrect_ForSpecificDatabase()
        {
            const string tableName = "Employees";

            const string correctDeleteStatement = "DELETE FROM Employees\r\nWHERE condition;";


            var result = QueryHelper.HardcodedQuery.Delete(tableName);


            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(correctDeleteStatement, result);
        }

        [Fact]
        public void UpdateStatementShouldBeCorrect_ForSpecificDatabase()
        {
            const string tableName = "Employees";
            var columns = new List<string>
            {
                "LastName",
                "FirstName",
                "Age"
            };

            const string correctUpdateStatement = "UPDATE Employees SET \r\nLastName = value0, FirstName = value1, Age = value2 \r\nWHERE condition;";


            var result = QueryHelper.HardcodedQuery.Update(tableName, columns);


            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(correctUpdateStatement, result);
        }
    }
}
