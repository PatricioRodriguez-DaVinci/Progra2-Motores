using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    public float _forceJump;
    public float _speed;
    Rigidbody _rigidBody;
    Transform _transform;

    public Movement(Transform tr, Rigidbody rb, float sp, float fj)
    {
        _forceJump = fj;
        _speed = sp;
        _rigidBody = rb;
        _transform = tr;
    }
    public void Move(float v, float h)
    {
        var dir = _transform.forward * v;
        dir += _transform.right * h;
        _transform.position += dir * _speed * Time.deltaTime;
    }

    public void Jump()
    {
        _rigidBody.AddForce(Vector3.up * _forceJump, ForceMode.Impulse);
    }

    public void Shoot()
    {
        Debug.Log("Disparo");
    }
}
