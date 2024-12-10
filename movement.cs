using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    [SerializeField]
    private Rigidbody2D rgbd;

    [SerializeField]
    float speed = 5.0f;

    [SerializeField]
    float jumpForce = 400.0f;

    void Update()
    {
        if(Input.GetKeyDown("space") & rgbd.IsTouchingLayers()){
            rgbd.AddRelativeForceY(jumpForce); //jump
            Debug.Log("space key was pressed");
         }
        rgbd.linearVelocityX = Input.GetAxis("Horizontal") * speed;  
    }

    private void FixedUpdate(){
         
    }
}
