using UnityEngine;

public class enemy_behaviour : MonoBehaviour
{

    [SerializeField]
    Collider2D coll;

    [SerializeField]
    int startDir = -1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SendMessage("SetDirection", startDir);
    }

    void Update()
    {
        //gameObject.SendMessage("Jump");
        //gameObject.SendMessage("SetDirection", currDir);
        //if(coll.OverlapPoint(leftPoint) | coll.OverlapPoint(rightPoint))
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy"){
            gameObject.SendMessage("FlipDirection");
        }
    }


    //enemy should move back and forth between 2 setpoints 
    //"detect" the player if theyre in their line of sight
    //can show an exclamation mark on top of their head when player is detected
    //speed up towards the player once detected
    
}
