using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] GameObject ShopUi;
    [SerializeField] GameObject Player;
    public TMP_Text sellText;
    public float sellTextTime;

    public int fish1price;
    public int fish2price;
    public int balance;

    private void Start()
    {
        pricing();
    }

    private void Update()
    {
        sellTextTime -= Time.deltaTime;
        if (sellTextTime < 0)
        {
            sellText.text = "";
        }
    }

    private void pricing()
    {
        fish1price = Random.Range(5, 10);
        fish2price = Random.Range(10, 15);
    }

    public void fish1sell()
    {
        if (PlayerInventory.Instance.fish1 > 0)
        {
            PlayerInventory.Instance.fish1 = PlayerInventory.Instance.fish1 - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + fish1price;
            sellTextTime = 2f;
            sellText.text = "Fish1 sold for " + fish1price.ToString() + " Coins";
        }
    }

    public void fish2sell()
    {
        if (PlayerInventory.Instance.fish2 > 0)
        {
            PlayerInventory.Instance.fish2 = PlayerInventory.Instance.fish2 - 1;
            PlayerInventory.Instance.balance = PlayerInventory.Instance.balance + fish2price;
            sellTextTime = 2f;
            sellText.text = "Fish2 sold for " + fish2price.ToString() + " Coins";
        }
    }

    public void ShopClose()
    {
        ShopUi.SetActive(false);
        Player.SetActive(true);
        Player.GetComponentInChildren<NewInputSystemPlayerMovement>().interactWaitTime = 0;
    }
}
