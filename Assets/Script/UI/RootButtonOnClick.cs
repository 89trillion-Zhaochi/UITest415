using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootButtonOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onclick()
    {
        GameObject panel = GameObject.Find("Daily Selection");
        if (panel != null)
        {
            panel.GetComponent<OpenDS>().OpenDailySelection();
        }
    }
}
