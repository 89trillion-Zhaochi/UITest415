using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HomePageScript : MonoBehaviour
{
    public  GameObject root;
    private GameObject _ds;
    private DailySelectionScript dailySelectionScript;
    
    // Start is called before the first frame update
    void Start()
    {
        //生成DS
        _ds = DailySelectionScript.LoadPage(root);
        dailySelectionScript = _ds.GetComponent<DailySelectionScript>();
    }
    
    public void RootButtonOnClick()
    {
        if (_ds != null)
        {
            dailySelectionScript.OpenDailySelection();
        }
    }
}