using DBManager.Core.Presenters;
using Xunit;

namespace DBManager.Tests.Assertion;

public static class ResponseAssert
{
    public static string Error<T>(Response<T> response) where T : class
        => Error(response.Type, response.ErrorMessage);

    public static string Error(Response response)
        => Error(response.Type, response.ErrorMessage);

    public static T Ok<T>(Response<T> response) where T : class
    {
        Assert.Equal(ResponseType.Ok, response.Type);
        Assert.NotNull(response.Payload);

        return response.Payload;
    }

    public static void Ok(Response response)
    {
        Assert.Equal(ResponseType.Ok, response.Type);
    }

    private static string Error(ResponseType responseType, string errorMessage)
    {
        Assert.Equal(ResponseType.Error, responseType);
        Assert.NotNull(errorMessage);

        return errorMessage;
    }
}
