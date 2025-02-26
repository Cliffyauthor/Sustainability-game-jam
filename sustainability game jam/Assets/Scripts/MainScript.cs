using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public TMP_Text DisAmo;
    public int Upmenu;
    public int CurrentValue;
    public int ClickValue;
    public Canvas start;
    public Canvas Main;
    public Canvas up1;
    public Canvas up2;
    public Canvas up3;
    // Start is called before the first frame update
    void Start()
    {
        Main.enabled = false;
        up1.enabled = false;
        up2.enabled = false;
        up3.enabled = false;
        start.enabled = true;
        ClickValue = 1;
        CurrentValue = 0;
        Upmenu = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Upmenu == 0)
        {
            up1.enabled = false;
            up2.enabled = false;
            up2.enabled = false;
        }
        if (Upmenu == 1)
        {
            up1.enabled = true;
            up2.enabled = false;
            up3.enabled =false;
        }
        if (Upmenu == 2)
        {
            up1.enabled = false;
            up2.enabled = true;
            up3.enabled = false;
        }
        if (Upmenu == 3)
        {
            up1.enabled = false;
            up2.enabled = false;
            up3.enabled = true;
        }

        DisAmo.text = CurrentValue.ToString("f0");
        
    }

    public void OnPlay()
    {
        Main.enabled = true;
        up1.enabled = true;
        up2.enabled = false;
        up3.enabled = false;
        start.enabled = false;
        Upmenu = 1;
    }


    
    public void OnUu()
    {
        Upmenu += 1;
        if (Upmenu > 3)
        {
            Upmenu = 3;
        }
    }
    public void OnUd()
    {
        Upmenu -=1;
        if (Upmenu < 1)
        {
            Upmenu = 1;
        }

    }
}
