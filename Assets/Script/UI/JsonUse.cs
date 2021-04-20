using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonUse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Loadpanel() //加载6个卡片panel的完整函数
    {
        Vector3[] panelpos = new Vector3[]//定义panel位置
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
        GameObject panel_1 = (GameObject)Instantiate(Resources.Load("Prefabs/CoinorDiomands"), panelpos[count], Quaternion.Euler(new Vector4(0, 0, 0f,0)));
        panel_1.name = "panel0";//赋予预制体在场景中的名字
        panel_1.transform.SetParent(GameObject.Find("Daily Selection").transform,true);
        panel_1.transform.localScale = new Vector3(1,1,1);
        panel_1.transform.localPosition = panelpos[count++];
        panel_1.GetComponent<PanelSet>().SetPanel(
            JsonDataManager.Instance.Mydata.dailyProduct[count-1].type,
            JsonDataManager.Instance.Mydata.dailyProduct[count-1].num,
            JsonDataManager.Instance.Mydata.dailyProduct[count-1].isPurchased);
        
        //加载第2-5个
        for (int i = 1; i < 5; i++)
        {
            GameObject panel_2_5 = (GameObject)Instantiate(Resources.Load("Prefabs/Cards"), panelpos[count], Quaternion.Euler(new Vector3(0, 0, 0f)));
            panel_2_5.name = "panel"+count.ToString();//赋予预制体在场景中的名字
            panel_2_5.transform.SetParent(GameObject.Find("Daily Selection").transform,true);
            panel_2_5.transform.localScale = new Vector3(1,1,1);
            panel_2_5.transform.localPosition = panelpos[count++];
            panel_2_5.GetComponent<PanelSet>().SetPanel(
                JsonDataManager.Instance.Mydata.dailyProduct[count-1].productId,
                JsonDataManager.Instance.Mydata.dailyProduct[count-1].type,
                JsonDataManager.Instance.Mydata.dailyProduct[count-1].subType,
                JsonDataManager.Instance.Mydata.dailyProduct[count-1].num,
                JsonDataManager.Instance.Mydata.dailyProduct[count-1].costGold,
                JsonDataManager.Instance.Mydata.dailyProduct[count-1].isPurchased);
        }

        //加载第6个
        GameObject panel_6 = (GameObject)Instantiate(Resources.Load("Prefabs/Unlock"), panelpos[count], Quaternion.Euler(new Vector3(0, 0, 0f)));
        panel_6.name = "panel"+count.ToString();//赋予预制体在场景中的名字
        panel_6.transform.SetParent(GameObject.Find("Daily Selection").transform,true); 
        panel_6.transform.localScale = new Vector3(1,1,1);
        panel_6.transform.localPosition = panelpos[count++];
    }

    public void Loadpage() //加载背景page
    {
        GameObject panel_1 = (GameObject)Instantiate(Resources.Load("Prefabs/Daily Selection"), new Vector3(0, 0, 0f), Quaternion.Euler(new Vector4(0, 0, 0f,0)));
        panel_1.name = "Daily Selection";//赋予预制体在场景中的名字
        panel_1.transform.SetParent(GameObject.Find("Root").transform,true);
        panel_1.transform.localScale = new Vector3(1,1,1);
        panel_1.transform.localPosition = new Vector3(0, 0, 0f);
    }

    public void Freepanel() //free
    {
        for (int i = 0; i < 6; i++)
        {
            GameObject panel = GameObject.Find("panel" + i.ToString());
            Destroy(panel);
        }
    }
}

