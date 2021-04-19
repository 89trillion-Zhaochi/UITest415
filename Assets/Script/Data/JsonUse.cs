﻿using System.Collections;
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

    public void load()
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
        panel_1.name = "panel1";//赋予预制体在场景中的名字
        panel_1.transform.SetParent(GameObject.Find("Daily Selection").transform,true);
        panel_1.transform.localScale = new Vector3(1,1,1);
        panel_1.transform.localPosition = panelpos[count++];
        panel_1.GetComponent<InitPanel>().Init(
            JsonDataManager.JsonData.mydata.dailyProduct[count-1].type,
            JsonDataManager.JsonData.mydata.dailyProduct[count-1].num,
            JsonDataManager.JsonData.mydata.dailyProduct[count-1].isPurchased);
        
        //加载第2-5个
        for (int i = 1; i < 5; i++)
        {
            GameObject panel_2_5 = (GameObject)Instantiate(Resources.Load("Prefabs/Cards"), panelpos[count], Quaternion.Euler(new Vector3(0, 0, 0f)));
            panel_2_5.name = "panel"+count.ToString();//赋予预制体在场景中的名字
            panel_2_5.transform.SetParent(GameObject.Find("Daily Selection").transform,true);
            panel_2_5.transform.localScale = new Vector3(1,1,1);
            panel_2_5.transform.localPosition = panelpos[count++];
            panel_2_5.GetComponent<InitPanel>().Init(
                JsonDataManager.JsonData.mydata.dailyProduct[count-1].productId,
                JsonDataManager.JsonData.mydata.dailyProduct[count-1].type,
                JsonDataManager.JsonData.mydata.dailyProduct[count-1].subType,
                JsonDataManager.JsonData.mydata.dailyProduct[count-1].num,
                JsonDataManager.JsonData.mydata.dailyProduct[count-1].costGold,
                JsonDataManager.JsonData.mydata.dailyProduct[count-1].isPurchased);
        }

        //加载第6个
        GameObject panel_6 = (GameObject)Instantiate(Resources.Load("Prefabs/Unlock"), panelpos[count], Quaternion.Euler(new Vector3(0, 0, 0f)));
        panel_6.name = "panel"+count.ToString();//赋予预制体在场景中的名字
        panel_6.transform.SetParent(GameObject.Find("Daily Selection").transform,true); 
        panel_6.transform.localScale = new Vector3(1,1,1);
        panel_6.transform.localPosition = panelpos[count++];
    }
}
