using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private AudioSource audioSource;

    [SerializeField] private AudioClip[] audioclips;

    public float jumpForce;
    private bool canFly;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        canFly = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canFly)
        {
            audioSource.clip = audioclips[0];
            audioSource.Play();
            rigidbody.AddForce(new Vector2(0, jumpForce));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Faz o player parar de se mover e toca som
        audioSource.clip = audioclips[1];
        audioSource.Play();
        canFly = false;
    }
}
