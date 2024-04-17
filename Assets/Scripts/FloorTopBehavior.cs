using UnityEngine;

public class FloorTopBehavior : MonoBehaviour
{
    private float velocity;
    private float minPositionX;
    private float spawnPositionX;

    private void Start()
    {        
        minPositionX = GameManager.Instance.minPositionX;
        spawnPositionX = GameManager.Instance.spawnPositionX;
    }

    private void Update()
    {
        velocity = GameManager.Instance.velocity;

        //Vector2.Left == new Vector2 (-1, 0) - Se move para esquerda em 1 unidade
        transform.Translate(Vector2.left * velocity * Time.deltaTime);

        if (transform.position.x < minPositionX)
        {
            Vector2 newPosition =
                new Vector2(spawnPositionX, transform.position.y);
            transform.position = newPosition;
        }
    }
}
