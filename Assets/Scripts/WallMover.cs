using System.Collections;
using UnityEngine;

public class WallMover : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        StartCoroutine(SpeedBoost());
    }

    private void Update()
    {
        if (!Killer.GameOver)
            transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

    private IEnumerator SpeedBoost()
    {
        while (true)
        {
            speed += 0.1f;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
