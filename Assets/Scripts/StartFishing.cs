using UnityEngine;

public class StartFishing : MonoBehaviour
{
    [SerializeField] GameObject fishing;
    [SerializeField] GameObject Player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Interact")
        {
            FishStart();
        }
    }

    public void FishStart()
    {
        fishing.SetActive(true);
        Player.SetActive(false);
    }
}
