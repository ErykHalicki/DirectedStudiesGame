using UnityEngine;
using TMPro;

public class player_score : MonoBehaviour
{

    public int score = 0;

    [SerializeField] 
    private TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddScore(int amount){
        score += amount;
        scoreText.text = "Score: " + score;
    }
}
