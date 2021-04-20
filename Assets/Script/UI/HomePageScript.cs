using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePageScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //生成DS
        this.GetComponent<JsonUse>().Loadpage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rootButtonOnClick()
    {
        //读取数据
        JsonDataManager.Instance.GETData();
        Debug.Log("Data has read successfully!");

        //生成panel
        this.GetComponent<JsonUse>().Loadpanel();
        GameObject panel = GameObject.Find("Daily Selection");
        //打开DS
        if (panel != null)
        {
            panel.GetComponent<OpenDS>().OpenDailySelection();
        }
        //隐藏button
        GameObject ob = GameObject.Find("OpenButton");
        ob.GetComponent<CanvasGroup>().alpha = 0;
        ob.GetComponent<CanvasGroup>().interactable = false;
        ob.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    
}
