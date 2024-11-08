public class GameState {
    public readonly SaveData saveData = new SaveData("data/savedata.props");
    public bool loseSwitch = false;
    public int drunkLevel {
        get { return saveData.GetOrDefault("drunk-level", 0); }
        set { saveData.SetValue("drunk-level", value); }
    }
    public int money {
        get { return saveData.GetOrDefault<int>("money", 200); }
        set { saveData.SetValue("money", Math.Max(0, value)); }
    }
}