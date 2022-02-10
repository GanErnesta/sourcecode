using UnityEngine;
using System.Collections;
 
public class Jump : MonoBehaviour {
    private Rigidbody rg;
    public float speed = 10.0F;
    public float jumpspeed = 10.0F;
    public float gravityScale = 5;
   
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        rg = GetComponent <Rigidbody> ();
    }
   
   
    void Update () {
        float translation = Input.GetAxis ("Vertical") * speed;
        float straffe = Input.GetAxis ("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
       
        transform.Translate (straffe, 0, translation);
       
        if (Input.GetKey (KeyCode.Space)) {
            Vector3 atas = new Vector3 (0,50,0);
            rg.AddForce(atas * speed);
        }
       
        if (Input.GetKeyDown ("escape"))
            Cursor.lockState = CursorLockMode.None;
       
       
    }
    private void FixedUpdate()
{
    rg.AddForce(Physics.gravity * (gravityScale - 1) * rg.mass);
}
   
}
