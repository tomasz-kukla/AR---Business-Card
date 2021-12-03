
using UnityEngine;

public class ProfileMovement : MonoBehaviour
{
    public Rigidbody rb;


  
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,100 * Time.deltaTime,0);

        
    }
}
