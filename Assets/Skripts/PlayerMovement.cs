using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 0f;
    public float sideForce = 0f;


    // Update is called once per frame
    //void Update()
    //{
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //if (Input.GetKey("d"))
        //{
        //rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}
        //if (Input.GetKey("a"))
        //{
        //rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}

        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //if (Input.touchCount > 0)
        //{
            //Touch touch = Input.GetTouch(0);
            //Vector3 touch_Pos = Camera.main.ScreenToWorldPoint(touch.position);
            //Debug.Log(touch_Pos);
            

            //if (touch_Pos.x <= Screen.width/2f)
            //{
                //rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //}if (touch_Pos.x > Screen.width/2f)
            //{
                //rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //}
        //}
    //}
}
