using UnityEngine;

public class StartFishing : MonoBehaviour
{
    [SerializeField] GameObject fishing;
    [SerializeField] GameObject Player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            fishing.SetActive(true);
            Player.SetActive(false);
        }
    }
}
