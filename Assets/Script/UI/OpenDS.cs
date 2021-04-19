using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CloseDailySelection();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenDailySelection()
    {
        GetComponent<CanvasGroup>().alpha = 1;
        GetComponent<CanvasGroup>().interactable = true;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    public void CloseDailySelection()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
