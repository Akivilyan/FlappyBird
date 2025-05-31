using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameManager GM;
    public int speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GM.playerDead)
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
    }
}
