using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    public float jumpForce;
    private bool canFly;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        canFly = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canFly)
        {
            rigidbody.AddForce(new Vector2(0, jumpForce));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Faz o player parar de se mover
        canFly = false;
    }
}
