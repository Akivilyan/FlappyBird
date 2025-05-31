using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameStart = false;
    public bool playerDead = false;
    public GameObject startGameBackground;
    public GameObject endGameBackground;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startGameBackground.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        gameStart = true;
        playerDead = false;
        endGameBackground.SetActive(false);
        startGameBackground.SetActive(false);
    }

    public void gameOver()
    {
        gameStart = false;
        playerDead = true;
        startGameBackground.SetActive(false);
        endGameBackground.SetActive(true);
    }
}
