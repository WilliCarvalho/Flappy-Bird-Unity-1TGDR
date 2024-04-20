using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
    public static GameBehavior gameBehavior;

    public Sprite[] pointImages;
    public Image pointDecimal;
    public Image pointUnit;
    public Image gameOverImage;

    private void Awake()
    {
        gameBehavior = this;
        SetEnableGameOverUI(false);
    }

    public void UpdateScoreUI(int score)
    {
        print("Ganhe um pontinho mizeravi!! Seus pontos: " + score);
        int unit = score % 10;
        int decimalPoint = score / 10;

        pointDecimal.sprite = pointImages[decimalPoint];
        pointUnit.sprite = pointImages[unit];
    }

    public void GameOver()
    {
        //Vamos avisar aos outros Scripts com nome behavior que o jogador perdeu
        SetEnableGameOverUI(true);
        print("Você bateu, perdeu otário!");
    }

    private void SetEnableGameOverUI(bool enable)
    {
        gameOverImage.gameObject.SetActive(enable);
    }
}
