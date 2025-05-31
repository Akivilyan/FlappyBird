using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int speed = 6;
    public Rigidbody2D rb;
    public int Score = 0;
    public GameManager GM;
    public Text scoreText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GM.gameStart)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!GM.playerDead)
            {
                rb.linearVelocityY = speed;
            }
        }

        Quaternion rotation = transform.rotation;
        Quaternion targetrotation;
        if (rb.linearVelocityY > 0)
        {
            targetrotation = Quaternion.Euler(0, 0, 30);
        }
        else if (rb.linearVelocityY < 0)
        {
            targetrotation = Quaternion.Euler(0, 0, -30);
        }
        else
        {
            targetrotation = Quaternion.Euler(0, 0, 0);
        }

        transform.rotation = Quaternion.RotateTowards(rotation, targetrotation, 400 * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boom")
        {
            GM.gameOver();
        }
        else if (collision.gameObject.tag == "floor")
        {
            GM.gameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "score")
        {
            Score += 10;
            scoreText.text = Score.ToString();
        }
    }

    private void GameOver()
    {
        GM.playerDead = true;
        GM.gameStart = false;
        //Time.timeScale = 0;
    }
}
