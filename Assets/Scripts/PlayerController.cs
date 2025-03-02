using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontal;
    private float forceStrength=10f;
    private float jumpForce=10f;
   


    private void Start(){
        rb=GetComponent<Rigidbody2D>();  
          
    }
    private void Update(){
        horizontal=Input.GetAxis("Horizontal")*forceStrength;
        if(horizontal>0){
            transform.localScale=new Vector3(1,1,1);
        }
        
        else if(horizontal<0){
            transform.localScale=new Vector3(-1,1,1);
        }
    }

    private void FixedUpdate(){
        
        rb.linearVelocity=new Vector3(horizontal,rb.linearVelocity.y,0);
    }
}
