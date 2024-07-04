using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class JSONStorage
{
    private static JSONStorage? _instance;
    private static readonly object Lock = new object();
    private Dictionary<string, object> _objects = new Dictionary<string, object>();
    private readonly string _directoryName = "storage";
    private readonly string _fileName = "inventory_manager.json";
    private string _filePath;

    private JSONStorage()
    {
        string baseDirectory = Path.GetDirectoryName(AppContext.BaseDirectory) ?? string.Empty;
        _filePath = Path.Combine(baseDirectory, _directoryName, _fileName);
        Directory.CreateDirectory(Path.Combine(baseDirectory, _directoryName));
    }

    public static JSONStorage Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new JSONStorage();
                    }
                }
            }
            return _instance;
        }
    }

    public Dictionary<string, object> All()
    {
        return _objects;
    }

    public void New(object obj)
    {
        if (obj is BaseClass baseObj)
        {
            string key = $"{obj.GetType().Name}.{baseObj.id}";
            _objects[key] = obj;
        }
        else
        {
            throw new ArgumentException("Object must be of type BaseClass.");
        }
    }

    public void Save()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(_objects, options);
        File.WriteAllText(_filePath, json);
    }

    public void Load()
    {
        if (File.Exists(_filePath))
        {
            string json = File.ReadAllText(_filePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _objects = JsonSerializer.Deserialize<Dictionary<string, object>>(json, options) ?? new Dictionary<string, object>();
        }
        else
        {
            Console.WriteLine("Storage file does not exist.");
        }
    }

    public void EmptyFile()
    {
        _objects.Clear();
        Save();
    }
}
