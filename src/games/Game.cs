public abstract class Game {
    public abstract string Name { get; }
    
    public abstract void PlayGame(GameState gameState);
}