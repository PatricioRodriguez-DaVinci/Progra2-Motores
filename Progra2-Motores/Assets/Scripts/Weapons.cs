using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    InstantiateObjects instantiate;
    [SerializeField] private GameObject bullet, spawnPoint;

    private void Start()
    {
        instantiate = new InstantiateObjects();

        if (instantiate == null)
        {
            Debug.LogWarning("Falta instantiate");
        }
        if (bullet == null)
        {
            Debug.LogWarning("Falta bullet");
        }
        if (spawnPoint == null)
        {
            Debug.LogWarning("Falta spawnPoint");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            instantiate.InstantiateObject(bullet, spawnPoint);
        }
    }

}
