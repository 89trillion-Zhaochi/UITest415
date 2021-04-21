using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HomePageScript : MonoBehaviour
{
    public  GameObject ob;
    // Start is called before the first frame update
    void Start()
    {
        //生成DS
        DailySelectionScript.LoadPage();
    }
    
    public void RootButtonOnClick()
    {
        //读取数据
        DSItemData dsItemData = new DSItemData();
        JsonDataManager.Instance.GetDataDSItem(ref dsItemData,"Json/data");
        //Debug.Log();

        //生成panel
        DailySelectionScript.Loadpanel(dsItemData);
        GameObject panel = GameObject.Find("Daily Selection");
        //打开DS
        if (panel != null)
        {
            panel.GetComponent<DailySelectionScript>().OpenDailySelection();
        }
        //隐藏button
        ob.GetComponent<CanvasGroup>().alpha = 0;
        ob.GetComponent<CanvasGroup>().interactable = false;
        ob.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void RootButtonshow()
    {
        ob.GetComponent<CanvasGroup>().alpha = 1;
        ob.GetComponent<CanvasGroup>().interactable = true;
        ob.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
   
}
