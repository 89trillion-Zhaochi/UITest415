using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class DSItemScript : MonoBehaviour
{
    public Text purchaesdText;

    public Button purchaesdButton;
    [SerializeField] private Text typeText;
    [SerializeField] private Image cardsImage;
    [SerializeField] private Text text;
    [SerializeField] private CanvasGroup okImage;
    [SerializeField] private CanvasGroup purchasedCanvasGroup;
    public void SetPanel(int productId, int type, int subtype, int num, int costGold, int isPurchased)
    {
        //当type=3时，对英雄图片进行加载,以及修改type字段显示
        if (type == 3)
        {
            typeText.text = "Cards";
            Texture2D img = Resources.Load("Image\\cards\\" + subtype.ToString()) as Texture2D;
            if (!(img is null))
            {
                Sprite pic = Sprite.Create(img, new Rect(0, 0, img.width, img.height), new Vector2(0.5f, 0.5f));
                cardsImage.sprite = pic;
                cardsImage.SetNativeSize();
                Debug.Log(pic.name + "has been set.");
            }
        }
        text.text = costGold.ToString();
        okImage.alpha = 0;
        okImage.interactable = false;
        okImage.blocksRaycasts = false;
    }

    public void SetPanel(int type, int num, int isPurchased)
    {
        if (type == 1)
        {
            typeText.text = "Coins";
            //加载显示图片
            Texture2D img = Resources.Load("Image\\coin_1") as Texture2D;
            Sprite pic = Sprite.Create(img, new Rect(0, 0, img.width, img.height), new Vector2(0.5f, 0.5f));
            cardsImage.sprite = pic;
            cardsImage.SetNativeSize();
        }
        else if (type == 2)
        {
            //加载type
            typeText.text = "Diamonds";
            //加载显示图片
            Texture2D img = Resources.Load("Image\\diamond_2") as Texture2D;
            Sprite pic = Sprite.Create(img, new Rect(0, 0, img.width, img.height), new Vector2(0.5f, 0.5f));
            cardsImage.sprite = pic;
            cardsImage.SetNativeSize();
        }
        okImage.alpha = 0;
        okImage.interactable = false;
        okImage.blocksRaycasts = false;
    }

    public void IsPurchasedShow()
    {
        purchasedCanvasGroup.alpha = 0;
        purchasedCanvasGroup.interactable = false;
        purchasedCanvasGroup.blocksRaycasts = false;
        okImage.alpha = 1;
        okImage.interactable = true;
        okImage.blocksRaycasts = true;
        purchaesdText.text = "Collected!";
    }
}