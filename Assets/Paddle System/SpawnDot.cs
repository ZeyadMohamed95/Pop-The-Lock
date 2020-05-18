using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDot : MonoBehaviour
{
    public AnchorMotor Paddle;
    public GameObject DotPrefab;

    void Start()
    {
        Spawn();
    }
    public void Spawn()
    {
        var Angle = Random.Range(45, 90);
        var Dot= Instantiate(DotPrefab, Paddle.transform.position, Quaternion.identity, this.gameObject.transform);
        Dot.transform.RotateAround(transform.position, Vector3.forward, (int)Paddle.direction* Angle);
    }
}
