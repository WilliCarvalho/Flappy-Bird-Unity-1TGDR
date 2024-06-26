using UnityEngine;

public class PipeBehavior : MonoBehaviour
{
    private float velocity;
    private float minPositionX;
    private float spawnPositionX;
    public float minPositionY = -1.78f;
    public float maxPositionY = 2.47f;

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

        if(transform.position.x < minPositionX)
        {
            Vector2 newPosition = 
                new Vector2(spawnPositionX, SetRandomYPosition());
            transform.position = newPosition;
        }
    }

    private float SetRandomYPosition()
    {
        return Random.Range(minPositionY, maxPositionY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.AddScorePoint(10);
    }
}
