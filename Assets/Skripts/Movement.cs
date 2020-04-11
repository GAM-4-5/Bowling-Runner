using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controllerPlayer;
    public Rigidbody rb;
    public float forwardForce = 0f;
    public float sideForce = 0f;
    public Transform player;

    void Start() 
    { 

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 mov = new Vector3(SimpleInput.GetAxis("Horizontal") * sideForce, 0, 0);
        //controllerPlayer.Move(mov * Time.deltaTime);
        Vector3 x = new Vector3(SimpleInput.GetAxis("Horizontal") * sideForce * Time.deltaTime,0, forwardForce);
        rb.velocity = x;
        if (player.position.z  % 1000 < 1 & player.position.z > 1){
            forwardForce += 5;
            sideForce += 700;
        }
    }
}
