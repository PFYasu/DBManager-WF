using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DBManager.Utils.Files;

public interface IFileManager
{
    T Load<T>(string path);
    List<T> LoadMany<T>(string directoryPath);
    void Save<T>(T entity, string path);
    void Delete(string path);
}

public class FileManager : IFileManager
{
    public T Load<T>(string path)
    {
        using (var reader = new StreamReader(path))
        {
            var json = reader.ReadToEnd();
            var entity = JsonConvert.DeserializeObject<T>(json);

            return entity;
        }
    }

    public List<T> LoadMany<T>(string directoryPath)
    {
        if (Directory.Exists(directoryPath) == false)
            return null;

        List<T> entities = new();

        foreach (var entityPath in Directory.GetFiles(directoryPath))
        {
            var entity = Load<T>(entityPath);

            entities.Add(entity);
        }

        return entities;
    }

    public void Save<T>(T entity, string path)
    {
        using (var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
        using (var streamWriter = new StreamWriter(fileStream))
        {
            var serializedConnection = JsonConvert.SerializeObject(entity);

            fileStream.SetLength(0);
            streamWriter.Write(serializedConnection);
        }
    }

    public void Delete(string path)
    {
        if (File.Exists(path) == false)
            throw new FileNotFoundException(path);

        File.Delete(path);
    }
}
