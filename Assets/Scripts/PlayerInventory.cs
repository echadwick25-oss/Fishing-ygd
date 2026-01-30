using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance;

    public FishingMinigame_Input fishing;
    private Shop shop;
    public int bell;
    public int binLid;
    public int copperBar;
    public int mask;
    public int metalScrap;
    public int shipWheel;
    public int stopSign;
    public int stopWatch;
    public int Wrench;
    public int balance;


    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
