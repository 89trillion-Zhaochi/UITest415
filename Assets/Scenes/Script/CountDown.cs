using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text text;
    [FormerlySerializedAs("TotalTime")] public int totalTime = 60;

    void Start()
    {
        StartCoroutine(Time());
    }

    IEnumerator Time()
    {
        while (totalTime >= 0)
        {
            text.text = "Refersh time:" + totalTime.ToString();
            yield return new WaitForSeconds(1);
            totalTime--;
        }

        if (totalTime == 0)
        {
            totalTime = 10;
        }
    }

    void update()
    {
        if (totalTime == 0)
        {
        }
    }
}