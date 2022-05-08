using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

{
    public GameObject tank;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(tank,new Vector3(13f,7.5f,17f),Quaternion.identity);
        

    }

   
}
