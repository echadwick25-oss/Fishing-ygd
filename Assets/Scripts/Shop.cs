using UnityEngine;

public class Shop : MonoBehaviour
{
    public PlayerInventory inventory;
    public FishingMinigame_Input fishing;
    public int fish1price;
    public int fish2price;
    public int balance;

    private void Start()
    {
        pricing();
    }

    private void pricing()
    {
        fish1price = Random.Range(5, 10);
        fish2price = Random.Range(10, 15);
    }

    public void fish1sell()
    {
        inventory.fish1 = inventory.fish1 - 1;
        balance = inventory.balance + fish1price;
    }

    public void fish2sell()
    {
        inventory.fish2 = inventory.fish2 - 1;
        balance = inventory.balance + fish2price;
    }
}
