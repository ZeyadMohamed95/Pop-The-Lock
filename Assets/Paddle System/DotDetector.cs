using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetector : MonoBehaviour
{
    public GameEvent DotScored;
    public GameEvent LoseGame;
    public GameEvent WinGame;
    public GameEvent ReloadLevel;
    public GameEvent Spawn;
    public GameData gamedata;
    public float MaxDistance;
    GameObject Circle;
    GameObject LastDot;
    
      private void OnTriggerEnter2D(Collider2D collision)
    {
        Circle = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Circle = null;
        LastDot = collision.gameObject;
    }

    void Update()
    {

        if (gamedata.SkipFrame) gamedata.SkipFrame = false;
        if (LastDot != null)
        {
            if (CalcDisatnce() > MaxDistance)
            {
                LoseGame.Raise();
                LastDot = null;
                gamedata.gameState = GameData.GameState.gameLost;
            }
        }
        
            if (Tapped && gamedata.gameState == GameData.GameState.gameRunning)
            {
                if (Circle != null)
                {
                Destroy(Circle);
                if (gamedata.NumberOfDots >= 1) DotScored.Raise();
                if (gamedata.NumberOfDots > 0 && gamedata.NumberOfDots!=gamedata.CurrentLevel) Spawn.Raise();
                if (gamedata.NumberOfDots == 0) WinGame.Raise();
                }
                else
                {
                LoseGame.Raise();
                gamedata.SkipFrame = true;
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
    float CalcDisatnce()
    {
        return (LastDot.transform.position - transform.position).magnitude;
    }
}
