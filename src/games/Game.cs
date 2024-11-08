public abstract class Game {
    public abstract string Name { get; }

    // just a shorthand to get the GameState
    protected GameState gameState {
        get { return Program.gameState; }
    }
    
    public abstract void Play();
}