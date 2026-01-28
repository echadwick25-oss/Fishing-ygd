using UnityEngine;

public class MarketToPath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
