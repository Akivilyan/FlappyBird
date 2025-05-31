using UnityEngine;

public class CreatObscaScript : MonoBehaviour
{
    public GameManager GM;
    public GameObject[] obstacles;
    public Transform spawnPoint;
    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //CreateObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (GM.gameStart && !GM.playerDead)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                CreateObstacle();
                timer = 0;
            }
        }
    }

    private void CreateObstacle()
    {
        int randomIndex = Random.Range(0, 5);
        Instantiate(obstacles[randomIndex], spawnPoint.position, spawnPoint.rotation);
    }
}
