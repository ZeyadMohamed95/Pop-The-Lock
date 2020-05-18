using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public GameEvent[] Events;
    public UnityEvent Response;

    private void OnEnable()
    {
        foreach (GameEvent Event in Events)
            Event.Register(this);
    }
    private void OnDisable()
    {
        foreach (GameEvent Event in Events)
            Event.Deregister(this);
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
