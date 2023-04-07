using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanGameObj : MonoBehaviour
{
    public GameObject objectPrefab;


    public void CreateObj()
    {
        GameObject newObj = Instantiate(objectPrefab, transform);
       
    }
}
