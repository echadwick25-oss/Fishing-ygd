using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance;

    public FishingMinigame_Input fishing;
    private Shop shop;
    public int fish1;
    public int fish2;
    public int balance;


    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
