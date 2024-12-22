using UnityEngine;

public class movement : MonoBehaviour
{
    LayerMask mask;

    [SerializeField]
    private Rigidbody2D rgbd;

    [SerializeField]
    private float speed = 5.0f;

    [SerializeField]
    private float jumpForce = 400.0f;

    [SerializeField]
    private bool isPlayer = false;

    private float direction = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mask = LayerMask.GetMask("Platforms");
    }

    public void Jump(){
        if(rgbd.IsTouchingLayers(mask)){
            rgbd.AddRelativeForceY(jumpForce);
        } 
    }

    public void SetDirection(float dir){
        direction = dir;
    }

    public void FlipDirection(){
        direction *= -1;
    }

    void Update()
    {
        if(isPlayer){
            SetDirection(Input.GetAxis("Horizontal")); 
            if(Input.GetKeyDown("space")){
                Jump();
            }
        }

        rgbd.linearVelocityX = direction * speed;  
    }
}
