//数据结构
[System.Serializable]
public class DailyProduct
{
    public int productId;
    public int type;
    public int subType;
    public int num;
    public int costGold;
    public int isPurchased;
}
[System.Serializable]
public class DSItemData
{
    public DailyProduct[] dailyProduct;
    public int dailyProductCountDown;
}
