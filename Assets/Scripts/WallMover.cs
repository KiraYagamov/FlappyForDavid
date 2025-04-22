using System.Collections;
using UnityEngine;

public class WallMover : MonoBehaviour
{
    [SerializeField] private float speed;
    public static float CurrentSpeed;

    private void Start()
    {
        CurrentSpeed = speed;
        StartCoroutine(SpeedBoost());
    }

    private void Update()
    {
        if (!Killer.GameOver)
            transform.Translate(Vector2.left * Time.deltaTime * CurrentSpeed);
    }

    private IEnumerator SpeedBoost()
    {
        while (true)
        {
            CurrentSpeed += 0.1f;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
