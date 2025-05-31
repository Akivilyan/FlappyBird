using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameManager GM;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GM.startGame();
    }
}
