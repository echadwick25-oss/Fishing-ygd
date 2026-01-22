using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance;

    public FishingMinigame_Input fishing;
    public int fish1;
    public int fish2;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        fish1 = fishing.fish1;
        fish2 = fishing.fish2;
    }
}
