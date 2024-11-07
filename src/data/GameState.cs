public class GameState {
    public SaveData saveData = new SaveData("data/savedata.props");
    public int drunkLevel = 0;
    public bool loseSwitch = false;
    public int money {
        get {
            if (!saveData.HasValue("money"))
                saveData.SetValue("money", 200);
            return saveData.GetValue<int>("money");
        }

        set {
            saveData.SetValue("money", value);
        }
    }
}