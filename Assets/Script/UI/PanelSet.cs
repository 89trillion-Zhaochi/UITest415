using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSet : MonoBehaviour
{
    public int type;
    public Text tname;
    public Text cost_text;
    public Image bg;
    public Image cardimage;
    public Image button;
    public Sprite type_bg;
    public Sprite type_cardimage;
    public Sprite type_button;
    public int cost;
    public Color namecolor;

    public Text heroname;

    // Start is called before the first frame update
    void Start()
    {
        Panelset();
    }

    // Update is called once per frame
    void Update()
    {
    }
    //设置panel的属性

    public void Panelset()
    {
        //设置标题
        switch (type)
        {
            case -1:
                tname.text = "None";
                break;
            case 0:
                tname.text = "Trophy";
                break;
            case 1:
                tname.text = "Coins";
                break;
            case 2:
                tname.text = "Diamonds";
                break;
            case 3:
                tname.text = "Cards";
                break;
            case 4:
                tname.text = "Chest";
                break;
            case 5:
                tname.text = "BattlePassExp";
                break;
            case 6:
                tname.text = "MasterLV";
                break;
            case 7:
                tname.text = "MasterEXP";
                break;
        }

        if (type_bg) bg.sprite = type_bg;
        if (type_cardimage) cardimage.sprite = type_cardimage;
        //button.sprite = type_button;
        bg.SetNativeSize();
        cardimage.SetNativeSize();
        if (cost != 0)
        {
            cost_text.text = cost.ToString();
        }
    }
}