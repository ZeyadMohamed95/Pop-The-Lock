using UnityEngine;
[CreateAssetMenu]
public class GameData : ScriptableObject
{
    public int CurrentLevel;
    public int NumberOfStars;
    public int NumberOfDots;
    public bool IsRunning;
    public bool SkipFrame=true;
    
    public enum GameState
    {
       gameBeginning,
       gameRunning,
       gameLost,
       gameWon
    }
   public GameState gameState = GameState.gameBeginning;
    public void ResetDots()
    {
        NumberOfDots = CurrentLevel;
    }
    public void ResetData()
    {
        ResetDots();
        gameState = GameState.gameBeginning;
    }
}
