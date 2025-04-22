using UnityEngine;

public class BubbleMover : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float verticalSpeed = 0.2f;

    private void Update(){
        transform.Translate(new Vector2(-speed * Time.deltaTime, verticalSpeed * Time.deltaTime));
    }
}
