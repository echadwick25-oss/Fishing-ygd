using UnityEngine;

public class OpenShop : MonoBehaviour
{
    [SerializeField] GameObject Shop;
    [SerializeField] GameObject Player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Interact")
        {
            ShopStart();
        }
    }

    public void ShopStart()
    {
        Shop.SetActive(true);
        Player.SetActive(false);
    }
}
