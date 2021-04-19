using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

//使用单例模式将读取的变量作为全局变量使用，提高访问速度
public class JsonDataManager : MonoBehaviour
{
    public TextAsset testJson;

    public static JsonDataManager JsonData;

    private void Awake()
    {
        JsonData = this; //使用单例模式，将数据作为全局变量
    }

    //暂时还没改完 
    //数据结构初始化
    [System.Serializable]
    public class DailyProduct
    {
        public int productId;
        public int type;
        public int subType;
        public int num;
        public int costGold;
        public int isPurchased;
    }

    [System.Serializable]
    public class MyData
    {
        public DailyProduct[] dailyProduct;
        public int dailyProductCountDown;
    }

    public MyData mydata = new MyData();


    private void Start()
    {
        mydata = JsonUtility.FromJson<MyData>(testJson.text);
        this.GetComponent<JsonUse>().loadpage();
        this.GetComponent<JsonUse>().loadpanel();
        
    }

    //设置panel的属性
    public Image image;
    public Sprite sprite;

    public void Panelset()
    {
        image.sprite = sprite;
    }
}