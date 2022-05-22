using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjects
{
    /// <summary>
    /// Método para crear un objeto (Qué vas a crear, Dónde lo vas a crear)
    /// </summary>
    /// <param name="whatInstantiate">Qué vas a crear</param>
    /// <param name="whereInstantiate">Dónde lo vas a crear</param>
    public void InstantiateObject(GameObject whatInstantiate, GameObject whereInstantiate)
    {
        GameObject.Instantiate(whatInstantiate, whereInstantiate.transform.position, whereInstantiate.transform.rotation);
        Debug.Log("Se crea un objeto");
    }
    
    
}
