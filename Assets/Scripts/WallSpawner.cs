using System.Collections;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    [SerializeField] private float delta;
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (!Killer.GameOver)
        {
            Vector2 wallPos = new Vector2(transform.position.x, transform.position.y + Random.Range(-delta, delta));
            GameObject newWall = Instantiate(wall, wallPos, Quaternion.identity);
            Destroy(newWall, 6f);
            yield return new WaitForSeconds(3f);
        }
    }
}
