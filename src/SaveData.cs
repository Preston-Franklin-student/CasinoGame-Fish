/// <summary>
/// A class that handles saving and loading key-value pairs to and from a file.
/// It supports storing and retrieving data with the specified keys as strings and values as various types.
/// </summary>
public class SaveData {
    
    /// <summary>
    /// A dictionary to store key-value pairs where both the key and value are strings.
    /// The value can be null (string?).
    /// </summary>
    private readonly Dictionary<string, string?> values = new();

    /// <summary>
    /// The path to the save file where data is stored.
    /// </summary>
    private readonly string saveFile;

    /// <summary>
    /// Initializes a new instance of the <see cref="SaveData"/> class.
    /// This constructor loads existing data from the specified save file, if it exists.
    /// </summary>
    /// <param name="saveFile">The path to the save file.</param>
    public SaveData(string saveFile) {
        this.saveFile = saveFile;

        string? directoryPath = Path.GetDirectoryName(saveFile);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath!);
        }

        // Create the file if it does not exist
        if (!File.Exists(saveFile))
        {
            using (FileStream fs = File.Create(saveFile)) { }
        }


        Load(); // Load existing data from the file when the object is created.
    }

    /// <summary>
    /// Saves the current key-value pairs to the specified save file.
    /// Each key-value pair is written to the file in the format 'key = value'.
    /// </summary>
    private void Save() {
        using (StreamWriter writer = new StreamWriter(saveFile)) {
            // Iterate through the dictionary and write each key-value pair to the file.
            foreach (string key in values.Keys) {
                writer.WriteLine($"{key}\t=\t{values[key]}");
            }
        }
    }

    /// <summary>
    /// Loads key-value pairs from the save file into the <see cref="values"/> dictionary.
    /// If the file doesn't exist, a new file will be created.
    /// Each line in the file must follow the 'key = value' format.
    /// </summary>
    private void Load() {
        // Read the file and parse key-value pairs.
        using (StreamReader reader = new StreamReader(saveFile)) {
            var line = reader.ReadLine();
            while (line != null) {
                // Only process lines that match the format 'key = value'
                if (line.IndexOf("\t=\t") == -1)
                    continue;

                // Split the line into key and value at the tab character '\t=\t'
                string key = line.Split("\t=\t")[0];
                string value = line.Split("\t=\t")[1];
                
                // Add the key-value pair to the dictionary.
                values[key] = value;

                // Move to the next line in the file.
                line = reader.ReadLine();
            }
        }
    }

    /// <summary>
    /// Retrieves the value associated with the specified key and attempts to convert it to the desired type.
    /// If the conversion fails, it returns the default value for the type.
    /// </summary>
    /// <typeparam name="T">The type to which the value should be converted.</typeparam>
    /// <param name="key">The key to look for in the dictionary.</param>
    /// <returns>The value associated with the key, converted to the specified type, or the default value if the conversion fails.</returns>
    public T GetValue<T>(string key) {
        // Attempt to retrieve the value as a string. If not found, default to null.
        string? value = values.GetValueOrDefault(key, null);

        try {
            // Attempt to convert the string value to the requested type T.
            return (T)Convert.ChangeType(value!, typeof(T));
        } catch {
            // If the conversion fails, return the default value for the type T.
            return default!;
        }
    }

    /// <summary>
    /// Sets a new value for the specified key and saves the updated key-value pair to the save file.
    /// </summary>
    /// <param name="key">The key to associate with the value.</param>
    /// <param name="value">The value to store, which will be converted to a string.</param>
    public void SetValue(string key, object? value) {
        // Convert the value to a string and store it in the dictionary.
        values[key] = value?.ToString();
        
        // Save the updated dictionary to the file.
        Save();
    }

    /// <summary>
    /// Checks whether the specified key exists in the collection of values.
    /// </summary>
    /// <param name="key">The key to check for in the collection.</param>
    /// <returns>
    /// <c>true</c> if the key exists in the collection; otherwise, <c>false</c>.
    /// </returns>
    /// <remarks>
    /// This method checks if the specified key is present in the internal collection (e.g., a dictionary or similar data structure).
    /// It can be useful for verifying whether a particular value or entry has been added to the collection before attempting to access or manipulate it.
    /// </remarks>
    public bool HasValue(string key) {
        return values.ContainsKey(key);
    }
}