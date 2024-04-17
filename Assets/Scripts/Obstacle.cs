using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
        print("Você bateu, perdeu otário!");
    }
}
