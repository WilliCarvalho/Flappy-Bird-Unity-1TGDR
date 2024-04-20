using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private AudioSource audiosource;

    private void Awake()
    {
        audiosource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audiosource.Play();
       GameBehavior.gameBehavior.GameOver();
    }    
}
