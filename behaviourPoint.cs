using UnityEngine;

public class behaviourPoint : MonoBehaviour
{

    [SerializeField]
    bool jump = false;

    [SerializeField]
    bool portal = false;

    [SerializeField]
    Vector3 portal_point;


    [SerializeField]
    float direction = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy"){
            if(jump)
                other.gameObject.SendMessage("Jump");
            else
                other.gameObject.SendMessage("SetDirection", direction);
        }

        if(other.gameObject.tag == "Player"){
            if(portal){
                other.gameObject.SendMessage("Teleport", portal_point);
            }
        }
    }
}
