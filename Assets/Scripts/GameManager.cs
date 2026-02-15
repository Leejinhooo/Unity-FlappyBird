using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int score = 0;
    private int bestScore = 0;
    public TextMeshProUGUI playInfoText;
    public Button restartButton;
    
    void Start()
    {
        restartButton.onClick.AddListener(Restart);
        restartButton.gameObject.SetActive(false);

    }
    public void AddScore(int value =1)
    {
        score += value;
        if(score>bestScore) bestScore = score;
        Debug.Log(score);
    }
    void Update()
    {
        if (playInfoText != null) playInfoText.text = $"Score: {score}\n" + $"Best:{bestScore}";
    }
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
