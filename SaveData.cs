public class SaveData {
    private Dictionary<string, string?> values = new();
    private readonly string saveFile;

    public SaveData(string saveFile) {
        this.saveFile = saveFile;
        Load();
    }

    private void Save() {
        using (StreamWriter writer = new StreamWriter(saveFile)) {
            foreach (string key in values.Keys) {
                writer.WriteLine($"{key}\t=\t{values[key]}");
            }
        }
    }

    private void Load() {
        // if the file doesn't exist create it
        if (!File.Exists(saveFile))
            using (FileStream fs = File.Create(saveFile)) {}

        using (StreamReader reader = new StreamReader(saveFile)) {
            var line = reader.ReadLine();
            while (line != null) {
                if (line.IndexOf("\t=\t") == -1)
                    continue;

                string key = line.Split("\t=\t")[0];
                string value = line.Split("\t=\t")[1];
                
                values[key] = value;

               
                line = reader.ReadLine();
            }
        }
    }

    public T GetValue<T>(string key) {
        string? value = values.GetValueOrDefault(key, null);
        try {
            return (T)Convert.ChangeType(value!, typeof(T));
        } catch {
            return default!;
        }
    }

    public void SetValue(string key, object? value) {
        values[key] = value?.ToString();
        Save();
    }
}