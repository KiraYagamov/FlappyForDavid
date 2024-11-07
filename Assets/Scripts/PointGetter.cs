using UnityEngine;

public class PointGetter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PointSystem.Instance.AddPoint();
        }
    }
}
