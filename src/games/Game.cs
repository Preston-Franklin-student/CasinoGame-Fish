public abstract class Game {
    public abstract string Name { get; }

    protected GameState gameState {
        get { return Program.gameState; }
    }
    
    public abstract void PlayGame();
}