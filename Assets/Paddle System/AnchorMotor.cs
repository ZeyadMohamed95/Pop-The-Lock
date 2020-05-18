using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorMotor : MonoBehaviour
{
    public int Speed = 5;
    public int MaxSpeed = 30;
    public int AcceleRate = 5;
    Transform Anchor;
    Vector3 InitialPosition;
    Quaternion intialRotation;
    public Direction direction;
    public GameData gamedata;
   


    void Start()
    {
        Anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
        InitialPosition = transform.localPosition;
        intialRotation = transform.rotation;
    }

    void Update()
    {
        
        if (gamedata.gameState == GameData.GameState.gameRunning)
        {
            transform.RotateAround(Anchor.position, Vector3.forward, Speed * Time.deltaTime * (int)direction);
            if (Tapped)
            {
                SwitchDirection();
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


    void SwitchDirection()
    {
        switch (direction)
        {
            case Direction.ClockWise:
                direction = Direction.AntiCloclWise;
                break;

            case Direction.AntiCloclWise:
                direction = Direction.ClockWise;
                break;
        } 
    }
   public void ResetPaddle()
    {
        transform.localPosition = InitialPosition;
        transform.rotation = intialRotation;
    }
    public void SpeedUp()
    {
        Speed += AcceleRate;
        Speed = Mathf.Clamp(Speed, 5, MaxSpeed);
    }
    
    public enum Direction
    {
        ClockWise = -1,
        AntiCloclWise =1
    }

    
}
