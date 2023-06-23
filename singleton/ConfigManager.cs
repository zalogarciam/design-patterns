public class ConfigManager
{
    private Dictionary<string, object> settings = new Dictionary<string, object>();
    private static ConfigManager Instance = new ConfigManager();
    private ConfigManager()
    {

    }

    public static ConfigManager GetInstance()
    {
        return Instance;
    }
    public void Set(string key, object value)
    {
        settings[key] = value;
    }

    public object Get(string key)
    {
        return settings[key];
    }
}