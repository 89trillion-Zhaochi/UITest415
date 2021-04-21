using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class DSItemScript : MonoBehaviour
{
    public Text purchaesdText;

    public Button purchaesdButton;
    
    public void SetPanel(int productId, int type, int subtype, int num, int costGold, int isPurchased)
    {
        //当type=3时，对英雄图片进行加载,以及修改type字段显示
        if (type == 3)
        {
            Text typeText = GameObject.Find("Type").GetComponent<Text>();
            typeText.text = "Cards";

            Transform trans = GetComponent<Transform>();
            Transform childTrans = trans.Find("CardImage");
            Image cardsImage = childTrans.GetComponent<Image>();
            Texture2D img = Resources.Load("Image\\cards\\" + subtype.ToString()) as Texture2D;
            if (!(img is null))
            {
                Sprite pic = Sprite.Create(img, new Rect(0, 0, img.width, img.height), new Vector2(0.5f, 0.5f));
                cardsImage.sprite = pic;
                cardsImage.SetNativeSize();
                Debug.Log(pic.name + "has been set.");
            }
        }
        //加载num

        //加载costGold
        GameObject cardsCost = GameObject.Find("CostGold");
        cardsCost.GetComponent<Text>().text = costGold.ToString();

        //加载是否可以购买
    }

    public void SetPanel(int type, int num, int isPurchased)
    {
        if (type == 1)
        {
            //加载type
            Text typeText = GameObject.Find("Type").GetComponent<Text>();
            typeText.text = "Coins";

            //加载显示图片
            Transform trans = GetComponent<Transform>();
            Transform childTrans = trans.Find("CardImage");
            Image cardsImage = childTrans.GetComponent<Image>();
            Texture2D img = Resources.Load("Image\\coin_1") as Texture2D;
            Sprite pic = Sprite.Create(img, new Rect(0, 0, img.width, img.height), new Vector2(0.5f, 0.5f));
            cardsImage.sprite = pic;
            cardsImage.SetNativeSize();
            Debug.Log(pic.name + "has been set.");
        }
        else if (type == 2)
        {
            //加载type
            Text typeText = GameObject.Find("Type").GetComponent<Text>();
            typeText.text = "Diamonds";

            //加载显示图片
            Transform trans = GetComponent<Transform>();
            Transform childTrans = trans.Find("CardImage");
            Image cardsImage = childTrans.GetComponent<Image>();
            Texture2D img = Resources.Load("Image\\diamond_2") as Texture2D;
            Sprite pic = Sprite.Create(img, new Rect(0, 0, img.width, img.height), new Vector2(0.5f, 0.5f));
            cardsImage.sprite = pic;
            cardsImage.SetNativeSize();
            Debug.Log(pic.name + "has been set.");
        }
        //加载num

        //加载ispurchase
    }

    public void IsPurchasedShow()
    {
        purchaesdButton.GetComponent<CanvasGroup>().alpha = 0;
        purchaesdButton.GetComponent<CanvasGroup>().interactable = false;
        purchaesdButton.GetComponent<CanvasGroup>().blocksRaycasts = false;
        purchaesdText.text = "Collected!";
    }
}