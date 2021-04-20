using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CloseDailySelection();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenDailySelection()
    {
        GetComponent<CanvasGroup>().alpha = 1;
        GetComponent<CanvasGroup>().interactable = true;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    public void CloseDailySelection()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void closeBSButtonOnClick()
    {
        //保存数据
        JsonDataManager.Instance.SaveData();
        //free panel
        GameObject.Find("Root").GetComponent<JsonUse>().Freepanel();
        //close 
        CloseDailySelection();
        
        //显示OpenButton
        GameObject ob = GameObject.Find("OpenButton");
        ob.GetComponent<CanvasGroup>().alpha = 1;
        ob.GetComponent<CanvasGroup>().interactable = true;
        ob.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
