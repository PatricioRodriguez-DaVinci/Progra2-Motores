using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjects
{
    /// <summary>
    /// M�todo para crear un objeto (Qu� vas a crear, D�nde lo vas a crear)
    /// </summary>
    /// <param name="whatInstantiate">Qu� vas a crear</param>
    /// <param name="whereInstantiate">D�nde lo vas a crear</param>
    public void InstantiateObject(GameObject whatInstantiate, GameObject whereInstantiate)
    {
        GameObject.Instantiate(whatInstantiate, whereInstantiate.transform.position, whereInstantiate.transform.rotation);
        Debug.Log("Se crea un objeto");
    }
    
    
}
