public class GameState {
    public readonly SaveData saveData = new SaveData("data/savedata.props");
    public bool loseSwitch = false;
    public int drunkLevel {
        get => saveData.GetOrDefault("drunk-level", 0);
        set => saveData.SetValue("drunk-level", Math.Max(0, value));
    }
    public int money
    {
        get => saveData.GetOrDefault("money", 200);
        set => saveData.SetValue("money", Math.Max(0, value)); 
    }
}