using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timer;
    public float timerset;
    public GameObject clicker;
    public float Xpos;
    public float Ypos;
    public GameObject objspawned;
    public GameObject par;

    void Start()
    {
        timerset = 5;
        
    }


    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timerset;
            Spawnin();
        }
        
    }
    
    void Spawnin()
    {
        Xpos = Random.Range(100,1180);
        Ypos = Random.Range(100,860);
        var objspawned = Instantiate(clicker, new Vector3(Xpos,Ypos,0), Quaternion.identity);
        objspawned.transform.parent = par.transform;
    }
}
