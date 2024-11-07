using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public static PointSystem Instance;
    private int _points;
    [SerializeField] private Text pointsText;
    [SerializeField] private AudioSource pointsAudio, gameOverSound, powerUpSound;
    [SerializeField] private Color[] colors;

    private void Start()
    {
        Instance = this;
    }

    public void AddPoint()
    {
        _points++;
        pointsText.text = $"Points: {_points}";
        pointsAudio.Play();

        if (_points % 5 == 0)
        {
            PowerUp();
        }
    }

    public int GetPoints()
    {
        return _points;
    }

    public void GameOver()
    {
        if (!gameOverSound.isPlaying)
            gameOverSound.Play();
        Killer.GameOver = true;
        Invoke(nameof(ReloadScene), 3f);
    }
    private void ReloadScene()
    {
        Killer.GameOver = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void PowerUp()
    {
        Time.timeScale += 0.2f;
        powerUpSound.Play();
        pointsText.color = colors[Random.Range(0, colors.Length)];
    }
}
