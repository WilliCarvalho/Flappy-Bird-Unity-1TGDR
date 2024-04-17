using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public UIManager uiManager;

    public float velocity;
    public float minPositionX = -4.3f;
    public float spawnPositionX = 4.3f;

    private int scorePoints;

    private void Awake()
    {
        scorePoints = 0;
        Instance = this;
    }

    public void AddScorePoint(int valueToAdd)
    {
        //scorePoints = scorePoints + valueToAdd
        scorePoints += valueToAdd;
        uiManager.UpdatePointsUI(scorePoints);
    }

    public void GameOver()
    {
        velocity = 0;
        uiManager.ShowGameOver();
    }
}
