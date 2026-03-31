using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Square")
        {
            FindObjectOfType<GameManager>().AddScore();
            Destroy(gameObject);
        }
    }
}