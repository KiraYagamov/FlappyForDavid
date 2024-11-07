using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private float rotationSpeed;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            _rb.velocity = Vector2.up * jumpForce;
        }
        transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * -rotationSpeed));
    }
}
