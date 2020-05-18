using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsInvoker : MonoBehaviour
{
    public GameEvent LoadNextLevel;
    public GameEvent Spawn;

    public void ToInvokeNextLevel()
    {
        LoadNextLevel.Raise();
    }
    public void ToSpawn()
    {
        Spawn.Raise();
    }

}
