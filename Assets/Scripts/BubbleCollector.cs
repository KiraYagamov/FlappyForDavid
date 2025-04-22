using UnityEngine;

public class BubbleCollector : MonoBehaviour
{
    [SerializeField] private float speedEffect;
    [SerializeField] private Animator animator;

    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            Time.timeScale += speedEffect;
            animator.SetTrigger("Explose");
            Destroy(gameObject, 0.5f);
        }
    }
}
