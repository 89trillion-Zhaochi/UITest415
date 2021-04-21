using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HomePageScript : MonoBehaviour
{
    public  GameObject root;

    private GameObject _ds;

    [SerializeField] private DailySelectionScript dailySelectionScript;
    // Start is called before the first frame update
    void Start()
    {
        //生成DS
        _ds = DailySelectionScript.LoadPage(root);
    }
    
    public void RootButtonOnClick()
    {
        //读取数据
        DSItemData dsItemData = new DSItemData();
        JsonDataManager.Instance.GetDataDSItem(ref dsItemData,"Json/data");
        //生成panel
        dailySelectionScript.LoadPanel(dsItemData,_ds);
        //打开DS
        if (_ds != null)
        {
            _ds.GetComponent<DailySelectionScript>().OpenDailySelection();
        }
    }

}
