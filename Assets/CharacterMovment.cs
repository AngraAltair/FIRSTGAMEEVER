using UnityEngine;

public class CharacterMovment : MonoBehaviour{
    public Rigidbody rb;

    public float run = 500f;
    // Start is called before the first frame update
    void Start()
    {

    }


    void FixedUpdate()
    {
        rb.AddForce(0, 0, run * Time.deltaTime);
        
        if (Input.GetKey("a")){
            rb.AddForce(-2000 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d")){
            rb.AddForce(2000 * Time.deltaTime, 0, 0);
        }    

        if (Input.GetKey("w")){
            rb.AddForce(0 , 500 * Time.deltaTime, 0);
        }
    }
}
