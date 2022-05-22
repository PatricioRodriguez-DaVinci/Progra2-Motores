using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] float velocity;
    private Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        if (rigidBody == null)
        {
            Debug.LogWarning("Falta rigidBody");
        }
    }
    void Update()
    {
        rigidBody.AddForce(transform.forward * velocity);
    }
}
