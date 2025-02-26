using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Cookie : MonoBehaviour
{
    public GameObject UImain;
    
    // Start is called before the first frame update
    void Start()
    {
        UImain = GameObject.Find("UI");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCookie()
    {
        UImain.GetComponent<MainScript>().CurrentValue += UImain.GetComponent<MainScript>().ClickValue;
        Destroy(gameObject);
    }
}
