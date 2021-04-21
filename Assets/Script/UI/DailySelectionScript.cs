using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DailySelectionScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private DSItemScript dsItemScript1;
    [SerializeField] private DSItemScript dsItemScript2_5;
    [SerializeField] private DSItemScript dsItemScript6;
    
    void Start()
    {
        CloseDailySelection();
    }

    public void OpenDailySelection()
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
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
        FreePanel();
        //close 
        CloseDailySelection();
    }
    
    public void LoadPanel(DSItemData dsItemData,GameObject ds) //加载6个卡片panel的完整函数
    {
        Vector3[] panelPos = new Vector3[]//定义panel位置
        {
            new Vector3(-352,380,0),
            new Vector3(0,380,0),
            new Vector3(352,380,0),
            new Vector3(-352,-253,0),
            new Vector3(0,-253,0),
            new Vector3(352,-253,0)
        };
        int count = 0;
        //加载第1个
        GameObject panel_1 = (GameObject)Instantiate(Resources.Load("Prefabs/CoinorDiomands"), panelPos[count], Quaternion.Euler(new Vector4(0, 0, 0f,0)));
        panel_1.name = "panel0";//赋予预制体在场景中的名字
        panel_1.transform.SetParent(ds.transform,true);
        panel_1.transform.localScale = new Vector3(1,1,1);
        panel_1.transform.localPosition = panelPos[count++];
        panel_1.GetComponent<DSItemScript>().SetPanel(
            dsItemData.dailyProduct[count-1].type,
            dsItemData.dailyProduct[count-1].num,
            dsItemData.dailyProduct[count-1].isPurchased);
        
        //加载第2-5个
        for (int i = 1; i < 5; i++)
        {
            GameObject panel_2_5 = (GameObject)Instantiate(Resources.Load("Prefabs/Cards"), panelPos[count], Quaternion.Euler(new Vector3(0, 0, 0f)));
            panel_2_5.name = "panel"+count.ToString();//赋予预制体在场景中的名字
            panel_2_5.transform.SetParent(ds.transform,true);
            panel_2_5.transform.localScale = new Vector3(1,1,1);
            panel_2_5.transform.localPosition = panelPos[count++];
            panel_2_5.GetComponent<DSItemScript>().SetPanel(
                dsItemData.dailyProduct[count-1].productId,
                dsItemData.dailyProduct[count-1].type,
                dsItemData.dailyProduct[count-1].subType,
                dsItemData.dailyProduct[count-1].num,
                dsItemData.dailyProduct[count-1].costGold,
                dsItemData.dailyProduct[count-1].isPurchased);
        }

        //加载第6个
        GameObject panel_6 = (GameObject)Instantiate(Resources.Load("Prefabs/Unlock"), panelPos[count], Quaternion.Euler(new Vector3(0, 0, 0f)));
        panel_6.name = "panel"+count.ToString();//赋予预制体在场景中的名字
        panel_6.transform.SetParent(ds.transform,true); 
        panel_6.transform.localScale = new Vector3(1,1,1);
        panel_6.transform.localPosition = panelPos[count++];
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

    public static void FreePanel() //free
    {
        for (int i = 0; i < 6; i++)
        {
            GameObject panel = GameObject.Find("panel" + i.ToString());
            Destroy(panel);
        }
    }
}
