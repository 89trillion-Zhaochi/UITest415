using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScollViewScript : MonoBehaviour
{
    [SerializeField] private Transform ts;
    public void LoadPanel() //加载6个卡片panel的完整函数
    {
        //读取数据
        DSItemData dsItemData = new DSItemData();
        JsonDataManager.Instance.GetDataDSItem(ref dsItemData,"Json/data");
        
        int count = 1;
        //加载第1个
        GameObject panel_1 = (GameObject) Instantiate(Resources.Load("Prefabs/CoinorDiomands"), Vector3.zero,
            Quaternion.Euler(Vector3.zero));
        panel_1.name = "panel1"+count.ToString();//赋予预制体在场景中的名字
        panel_1.transform.parent = ts;//加载父子关系
        panel_1.transform.localScale = new Vector3(1,1,1);//加载基础缩放
        panel_1.GetComponent<DSItemScript>().SetPanel(
            dsItemData.dailyProduct[count-1].type,
            dsItemData.dailyProduct[count-1].num,
            dsItemData.dailyProduct[count-1].isPurchased);
        count++;
        
        //加载第2-5个
        for (int i = 1; i < 5; i++)
        {
            GameObject panel_2_5 = (GameObject)Instantiate(Resources.Load("Prefabs/Cards"),Vector3.zero,
                Quaternion.Euler(Vector3.zero));
            panel_2_5.name = "panel"+count.ToString();//赋予预制体在场景中的名字
            panel_2_5.transform.parent = ts;
            panel_2_5.transform.localScale = new Vector3(1,1,1);
            panel_2_5.GetComponent<DSItemScript>().SetPanel(
                dsItemData.dailyProduct[count-1].productId,
                dsItemData.dailyProduct[count-1].type,
                dsItemData.dailyProduct[count-1].subType,
                dsItemData.dailyProduct[count-1].num,
                dsItemData.dailyProduct[count-1].costGold,
                dsItemData.dailyProduct[count-1].isPurchased);
            count++;
        }

        //加载第6个
        GameObject panel_6 = (GameObject)Instantiate(Resources.Load("Prefabs/Unlock"), Vector3.zero,
            Quaternion.Euler(Vector3.zero));
        panel_6.name = "panel"+count.ToString();//赋予预制体在场景中的名字
        panel_6.transform.parent = ts;
        panel_6.transform.localScale = new Vector3(1,1,1);
    }
    
    public void FreePanel() //free
    {
        foreach (Transform child in ts)
            Destroy(child.gameObject);
    }
   
}
