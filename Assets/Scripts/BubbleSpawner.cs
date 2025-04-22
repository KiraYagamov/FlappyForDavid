using UnityEngine;
using System.Collections;

public class BubbleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] bubblePrefabs;
    [SerializeField] private float delta = 4f;
    [SerializeField] private float timeFrom = 3f, timeTo = 9f;
    [SerializeField] private float timeToDestroy = 10f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (!Killer.GameOver)
        {
            Vector2 bubblePos = new Vector2(transform.position.x, transform.position.y + Random.Range(-delta, delta));
            GameObject bubblePrefab = bubblePrefabs[Random.Range(0, bubblePrefabs.Length)];
            GameObject newBubble = Instantiate(bubblePrefab, bubblePos, Quaternion.identity);
            Destroy(newBubble, timeToDestroy);
            yield return new WaitForSeconds(Random.Range(timeFrom, timeTo));
        }
    }
}
