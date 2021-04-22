using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DailySelectionScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private ScollViewScript scrollViewScript;
    void Start()
    {
        CloseDailySelection();
    }
    public void OpenDailySelection()
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        scrollViewScript.LoadPanel();
    }
    public void CloseDailySelection()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        
    }
    public void CloseBSButtonOnClick()
    {
        //free panel
        scrollViewScript.FreePanel();
        //close 
        CloseDailySelection();
    }
    
    public static GameObject LoadPage(GameObject root) //加载背景page
    {
        GameObject panel_1 = (GameObject)Instantiate(Resources.Load("Prefabs/Daily Selection"), new Vector3(0, 0, 0f), Quaternion.Euler(new Vector4(0, 0, 0f,0)));
        panel_1.name = "Daily Selection";//赋予预制体在场景中的名字
        panel_1.transform.SetParent(root.transform,true);
        panel_1.transform.localScale = new Vector3(1,1,1);
        panel_1.transform.localPosition = new Vector3(0, 0, 0f);
        return panel_1;
    }

    
}
