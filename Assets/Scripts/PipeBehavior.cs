using UnityEngine;

public class PipeBehavior : MonoBehaviour
{
    public float velocity;
    public float minPositionX = -4.3f;
    public float spawnPositionX = 4.3f;
    public float minPositionY = -1.78f;
    public float maxPositionY = 2.47f;

    private int points;

    private void Start()
    {
        //TODO: Setar altura aleatória do cano    
    }

    private void Update()
    {
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
        points++;
        print("Ganhe um pontinho mizeravi!! Seus pontos: " + points);
    }
}
