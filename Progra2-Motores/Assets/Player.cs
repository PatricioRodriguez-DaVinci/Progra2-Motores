using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Movement _movement;
    Control _control;
    public float speed;
    public float forceJump;
    public Rigidbody rb;

    private void Start()
    {
        _movement = new Movement(transform, rb, speed, forceJump);
        _control = new Control(_movement);


    }

    void Update()
    {
        _control.ManualUpdate();
    }
}