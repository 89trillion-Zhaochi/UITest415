using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class DSItem : MonoBehaviour
{
    public Text purchaesdText;

    public Button purchaesdButton;
    [SerializeField] private Text typeText;
    [SerializeField] private Image cardsImage;
    [SerializeField] private Text text;
    [SerializeField] private CanvasGroup okImage;
    [SerializeField] private CanvasGroup purchasedCanvasGroup;
    [SerializeField] private List<Texture2D> imgList;

    //int productId, int type, int subtype, int num, int costGold, int isPurchased
    public void SetPanel_6(DailyProduct dailyProduct)
    {
        if (dailyProduct.type == 3)
        {
            typeText.text = "Cards";
            if (!(imgList[dailyProduct.subType] is null))
            {
                Sprite pic = Sprite.Create(imgList[dailyProduct.subType],
                    new Rect(0, 0, imgList[dailyProduct.subType].width, imgList[dailyProduct.subType].height),
                    new Vector2(0.5f, 0.5f));
                cardsImage.sprite = pic;
                cardsImage.SetNativeSize();
            }
        }

        text.text = dailyProduct.costGold.ToString();
        okImage.alpha = 0;
    }

    public void SetPanel_3(DailyProduct dailyProduct)
    {
        if (dailyProduct.type == 1)
        {
            typeText.text = "Coins";
            //加载显示图片
            if (!(imgList[dailyProduct.subType] is null))
            {
                Sprite pic = Sprite.Create(imgList[dailyProduct.type - 1],
                    new Rect(0, 0, imgList[dailyProduct.type - 1].width, imgList[dailyProduct.type - 1].height),
                    new Vector2(0.5f, 0.5f));
                cardsImage.sprite = pic;
                cardsImage.SetNativeSize();
            }
        }
        else if (dailyProduct.type == 2)
        {
            //加载type
            typeText.text = "Diamonds";
            //加载显示图片
            if (!(imgList[dailyProduct.subType] is null))
            {
                Sprite pic = Sprite.Create(imgList[dailyProduct.type - 1],
                    new Rect(0, 0, imgList[dailyProduct.type - 1].width, imgList[dailyProduct.type - 1].height),
                    new Vector2(0.5f, 0.5f));
                cardsImage.sprite = pic;
                cardsImage.SetNativeSize();
            }
        }

        okImage.alpha = 0;
    }

    public void IsPurchasedShow()
    {
        purchasedCanvasGroup.alpha = 0;
        okImage.alpha = 1;
        purchaesdText.text = "Collected!";
    }
}