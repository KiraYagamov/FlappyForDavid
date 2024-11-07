using UnityEngine;
using UnityEngine.SceneManagement;

public class Killer : MonoBehaviour
{
    public static bool GameOver;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PointSystem.Instance.GameOver();
        }
    }
}
