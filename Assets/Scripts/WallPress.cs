using UnityEngine;

public class WallPress : MonoBehaviour
{
    [SerializeField] private GameObject wallUp, wallDown;
    [SerializeField] private float speed;

    private bool _whereMoving = false;
    private float _seconds = 0;
    [SerializeField] private float maxTime;

    private void Update()
    {
        if (!_whereMoving)
        {
            wallUp.transform.Translate(Vector3.down * speed * Time.deltaTime);
            wallDown.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            wallUp.transform.Translate(Vector3.up * speed * Time.deltaTime);
            wallDown.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        _seconds += Time.deltaTime;
        if (_seconds >= maxTime)
        {
            _seconds = 0;
            _whereMoving = !_whereMoving;
        }
    }
}
