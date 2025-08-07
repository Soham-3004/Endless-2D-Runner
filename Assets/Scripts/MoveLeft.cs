using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private PlayerController PlayerControllerScript;
    private float moveleft = -15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < moveleft && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
