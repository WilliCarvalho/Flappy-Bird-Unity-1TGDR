using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Voc� bateu, perdeu ot�rio!");
    }
}
