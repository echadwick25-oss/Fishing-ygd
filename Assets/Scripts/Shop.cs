using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] GameObject ShopUi;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject BellSprite;
    [SerializeField] GameObject BinLidSprite;
    [SerializeField] GameObject CopperBarSprite;
    [SerializeField] GameObject MaskSprite;
    [SerializeField] GameObject MetalScrapSprite;
    [SerializeField] GameObject ShipWheelSprite;
    [SerializeField] GameObject StopSignSprite;
    [SerializeField] GameObject StopWatchSprite;
    [SerializeField] GameObject WrenchSprite;

    public TMP_Text sellText;
    public float sellTextTime;


    public int price;
    public int balance;

    private void Update()
    {
        sellTextTime -= Time.deltaTime;
        if (sellTextTime < 0)
        {
            sellText.text = "";
            //BellSprite.SetActive(false);
            //BinLidSprite.SetActive(false);
            //CopperBarSprite.SetActive(false);
            //MaskSprite.SetActive(false);
            //MetalScrapSprite.SetActive(false);
            //ShipWheelSprite.SetActive(false);
            //StopSignSprite.SetActive(false);
            //StopWatchSprite.SetActive(false);
            //WrenchSprite.SetActive(false);
        }
    }

    private void Pricing()
    {
        price = Random.Range(1, 100);
    }

    public void BellSell()
    {
        if (PlayerInventory.Instance.bell > 0)
        {
            Pricing();
            PlayerInventory.Instance.bell = PlayerInventory.Instance.bell - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + price;
            sellTextTime = 2f;
            sellText.text = "Bell sold for " + price.ToString() + " Coins";
            BellSprite.SetActive(true);
        }
    }

    public void BinLidSell()
    {
        if (PlayerInventory.Instance.binLid > 0)
        {
            Pricing();
            PlayerInventory.Instance.binLid = PlayerInventory.Instance.binLid - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + price;
            sellTextTime = 2f;
            sellText.text = "Bin Lid sold for " + price.ToString() + " Coins";
            //BinLidSprite.SetActive(true);
        }
    }
    public void CopperBarSell()
    {
        if (PlayerInventory.Instance.copperBar > 0)
        {
            Pricing();
            PlayerInventory.Instance.copperBar = PlayerInventory.Instance.copperBar - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + price;
            sellTextTime = 2f;
            sellText.text = "Copper Bar sold for " + price.ToString() + " Coins";
            //CopperBarSprite.SetActive(true);
        }
    }
    public void MaskSell()
    {
        if (PlayerInventory.Instance.mask > 0)
        {
            Pricing();
            PlayerInventory.Instance.mask = PlayerInventory.Instance.mask - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + price;
            sellTextTime = 2f;
            sellText.text = "Mask sold for " + price.ToString() + " Coins";
            //MaskSprite.SetActive(true);
        }
    }
    public void MetalScrapSell()
    {
        if (PlayerInventory.Instance.metalScrap > 0)
        {
            Pricing();
            PlayerInventory.Instance.metalScrap = PlayerInventory.Instance.metalScrap - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + price;
            sellTextTime = 2f;
            sellText.text = "Metal Scrap sold for " + price.ToString() + " Coins";
            //MetalScrapSprite.SetActive(true);
        }
    }
    public void ShipWheelSell()
    {
        if (PlayerInventory.Instance.shipWheel > 0)
        {
            Pricing();
            PlayerInventory.Instance.shipWheel = PlayerInventory.Instance.shipWheel - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + price;
            sellTextTime = 2f;
            sellText.text = "Ship Wheel sold for " + price.ToString() + " Coins";
            //ShipWheelSprite.SetActive(true);
        }
    }
    public void StopSignSell()
    {
        if (PlayerInventory.Instance.stopSign > 0)
        {
            Pricing();
            PlayerInventory.Instance.stopSign = PlayerInventory.Instance.stopSign - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + price;
            sellTextTime = 2f;
            sellText.text = "Stop Sign sold for " + price.ToString() + " Coins";
            //StopSignSprite.SetActive(true);
        }
    }
    public void StopWatchSell()
    {
        if (PlayerInventory.Instance.stopWatch > 0)
        {
            Pricing();
            PlayerInventory.Instance.stopWatch = PlayerInventory.Instance.stopWatch - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + price;
            sellTextTime = 2f;
            sellText.text = "Stop Watch sold for " + price.ToString() + " Coins";
            //StopWatchSprite.SetActive(true);
        }
    }
    public void WrenchSell()
    {
        if (PlayerInventory.Instance.Wrench > 0)
        {
            Pricing();
            PlayerInventory.Instance.Wrench = PlayerInventory.Instance.Wrench - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + price;
            sellTextTime = 2f;
            sellText.text = "Wrench sold for " + price.ToString() + " Coins";
            //WrenchSprite.SetActive(true);
        }
    }


    public void ShopClose()
    {
        ShopUi.SetActive(false);
        Player.SetActive(true);
        Player.GetComponentInChildren<NewInputSystemPlayerMovement>().interactWaitTime = 0;
    }
}
