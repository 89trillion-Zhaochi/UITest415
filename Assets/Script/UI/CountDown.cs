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
        yield return StartCoroutine(TimeCountDown());
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
}