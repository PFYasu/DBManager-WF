using DBManager.Utils.Files;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DBManager.Tests;

public class FileManagerTestDriver : IFileManager
{
    private readonly Dictionary<string, object> _entities = new();

    public T Load<T>(string path) where T : class
    {
        if (_entities.ContainsKey(path) == false)
            return null;

        return (T)_entities[path];
    }

    public List<T> LoadMany<T>(string directoryPath) where T : class
    {
        List<T> entities = new();

        var matchedEntityPaths = _entities
            .Where(x => x.Key.StartsWith(directoryPath))
            .Select(x => x.Key)
            .ToList();

        foreach (var matchedEntityPath in matchedEntityPaths)
        {
            var entity = Load<T>(matchedEntityPath);

            entities.Add(entity);
        }

        return entities;
    }

    public void Save<T>(T entity, string path) where T : class
        => _entities[path] = entity;

    public void Delete(string path)
        => _entities.Remove(path);

    public T AssertFileExists<T>(string path) where T : class
    {
        var entity = _entities[path];

        Assert.NotNull(entity);
        return (T)entity;
    }

    public void AssertFileNotExist(string path)
    {
        var entity = _entities.Keys.SingleOrDefault(x => x == path);

        Assert.Null(entity);
    }
}
