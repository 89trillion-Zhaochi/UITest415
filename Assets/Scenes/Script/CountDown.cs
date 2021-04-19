using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text text;
    public int TotalTime = 60;

    void Start()
    {
        StartCoroutine(Time());
    }

    IEnumerator Time()
    {
        while (TotalTime >= 0)
        {
            text.text = "Refersh time:" + TotalTime.ToString();
            yield return new WaitForSeconds(1);
            TotalTime--;
        }

        if (TotalTime == 0)
        {
            TotalTime = 10;
        }
    }

    void update()
    {
        if (TotalTime == 0)
        {
        }
    }
}