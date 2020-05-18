using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData gamedata;
    public GameEvent OnWinEvent;
    public GameEvent reloadLevel;
    public GameEvent FirstTapped;
    public GameEvent Spawn;
    public bool FirstTap=true;

    void Start()
    {
        gamedata.ResetData();
        gamedata.IsRunning= false;
        FirstTap = true;
    }
    void Update()
    {
        if (!gamedata.SkipFrame)
        {
            if (Tapped && gamedata.gameState == GameData.GameState.gameBeginning)
            {
                gamedata.gameState = GameData.GameState.gameRunning;
                FirstTapped.Raise();
            }
            else if (Tapped && gamedata.gameState == GameData.GameState.gameLost)
            {
                reloadLevel.Raise();
                GameObject dot = GameObject.FindGameObjectWithTag("Dot");
                if (dot != null) Destroy(dot);
                Spawn.Raise();
            }
        }
        
    }
    bool Tapped
    {
        get
        {
            return Input.GetMouseButtonDown(0);
        }
    }
    public void WinGame()
    {
        gamedata.gameState = GameData.GameState.gameWon;
    }
    public void DecrementDots()
    {
        gamedata.NumberOfDots--;
        if(gamedata.NumberOfDots<=0)
        {
            gamedata.NumberOfDots = 0;
            OnWinEvent.Raise();
        }
    }
    public void LoadNextLevel()
    {
        gamedata.CurrentLevel++;
        gamedata.ResetData();
        gamedata.gameState = GameData.GameState.gameBeginning;

    }
    public void ReloadLevel()
    {
        gamedata.ResetDots();
        gamedata.gameState = GameData.GameState.gameBeginning;

    }
    public void Stop()
    {
        gamedata.gameState = GameData.GameState.gameLost;
    }
        
}
