﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePage : MonoBehaviour
{
    [SerializeField] private Transform rootTS;
    private GameObject _ds;

    public void RootButtonOnClick()
    {
        if (_ds == null)
        {
            _ds = (GameObject) Instantiate(Resources.Load("Prefabs/Daily Selection"), Vector3.zero,
                Quaternion.Euler(Vector3.zero));
            _ds.GetComponent<Transform>().transform.parent = rootTS;
            _ds.name = "Daily Selection"; //赋予预制体在场景中的名字
            _ds.transform.localScale = Vector3.one;
            _ds.transform.localPosition = Vector3.zero;
            _ds.GetComponent<DailySelection>().LoadPanel();
        }
    }
}