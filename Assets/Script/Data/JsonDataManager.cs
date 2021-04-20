using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

//使用单例模式将读取的变量作为全局变量使用，提高访问速度
public class JsonDataManager:UnitySingletonNoMB<JsonDataManager>
{
    public TextAsset textJson  = Resources.Load("Json/data") as TextAsset;

    public static JsonDataManager JsonData;
    private void Awake()
    {
        JsonData = this; //使用单例模式，将数据作为全局变量
    }
    
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

    public MyData Mydata = new MyData();

    public void GETData()
    {
        Mydata = JsonUtility.FromJson<MyData>(textJson.text);
        Debug.Log(Application.dataPath);
    }

    public void SaveData()
    {
        string json = JsonUtility.ToJson(Mydata);
        StreamWriter sw = new StreamWriter("JSON\\data.json");
        if(json.Length!=0)
        sw.Write(json);
        sw.Close();

        // File.WriteAllLines("JSON\\data.json",json);
    }
}