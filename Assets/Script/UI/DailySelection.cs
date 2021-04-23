using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DailySelection : MonoBehaviour
{
    [SerializeField] private Transform contentTS;
    [SerializeField] private Transform dsTransform;
    [SerializeField] private List<GameObject> panelitem; //0 is coin,1 is cards,2 is unlock
    [SerializeField] private int item_length = 6;

    private void Start()
    {
        LoadPanel();
        panelitem.Capacity = 7;
    }

    public void DestoryDailySelection()
    {
        DestoryPanel();
        Destroy(dsTransform.gameObject);
    }

    public void LoadPanel() //加载6个卡片panel的完整函数
    {
        //读取数据
        DSItemData dsItemData = new DSItemData();
        JsonDataManager.Instance.GetDataDSItem(ref dsItemData, "Json/data");

        int dataLength = dsItemData.dailyProduct.Length; //获取json中的数据数量
        for (int i = 0; i < dataLength; ++i)
        {
            GameObject panel = null;
            if (dsItemData.dailyProduct[i].type == 1 || dsItemData.dailyProduct[i].type == 2) //type = 1 or 2
            {
                panel = Instantiate(panelitem[0]);
            }
            else if (dsItemData.dailyProduct[i].type == 3) //type = 3
            {
                panel = Instantiate(panelitem[1]);
            }

            panel.name = "panel" + i.ToString(); //赋予预制体在场景中的名字
            panel.transform.SetParent(contentTS, false); //加载父子关系
            panel.transform.localScale = new Vector3(1, 1, 1); //加载基础缩放
            panel.GetComponent<DSItem>().SetPanel(dsItemData.dailyProduct[i]);
        }

        //加载完JSON中的数据后，按照空闲数量生成unlock
        for (int i = dataLength; i < item_length; ++i)
        {
            GameObject panel = Instantiate(panelitem[2], contentTS, false);
            panel.name = "panel" + i.ToString(); //赋予预制体在场景中的名字
            panel.transform.localScale = new Vector3(1, 1, 1); //加载基础缩放
        }
    }

    public void DestoryPanel()
    {
        foreach (Transform child in contentTS)
            Destroy(child.gameObject);
    }
}