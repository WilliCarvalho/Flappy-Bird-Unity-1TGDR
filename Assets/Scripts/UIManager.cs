using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Sprite[] pointImages;
    public Image pointDecimal;
    public Image pointUnit;
    public Image gameOverImage;

    public void UpdatePointsUI(int point)
    {
        int unit = point % 10;
        int decimalPoint = point / 10;

        pointDecimal.sprite = pointImages[decimalPoint];
        pointUnit.sprite = pointImages[unit];
    }

    public void ShowGameOver()
    {
        gameOverImage.gameObject.SetActive(true);
    }
}
