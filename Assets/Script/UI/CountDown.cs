using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text text;
    public int totalTime = 60;

    IEnumerator Start()
    {
        Debug.Log("starting:"+Time.time);
        yield return StartCoroutine(TimeCountDown());
        Debug.Log("end:"+Time.time);
    }

    private IEnumerator TimeCountDown()
    {
        while (totalTime >= 0)
        {
            text.text = "Refersh time:" + totalTime.ToString();
            yield return new WaitForSeconds(1);
            totalTime--;
        }
        yield return null;
    }
    //另外一种写法,待确认
    // void start()
    // {
    //     StartCoroutine(TimeCountDown());
    // }
    // void update()
    // {
    //     if (totalTime <= 0)
    //     {
    //         StopCoroutine(TimeCountDown());
    //     }
    // }
}