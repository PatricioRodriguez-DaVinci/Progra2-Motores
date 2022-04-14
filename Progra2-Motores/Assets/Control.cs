using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control
{
    public Movement _movement;

    public Control(Movement m)
    {
        _movement = m;
    }
    public void ManualUpdate()
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");

        if (h != 0 || v != 0)
        {
            _movement.Move(h, v);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _movement.Jump();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _movement.Shoot();
        }
    }
}
