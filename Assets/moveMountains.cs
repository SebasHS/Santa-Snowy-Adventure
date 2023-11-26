using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMountains : MonoBehaviour
{
    public float speed = 4;
    public Rigidbody rb;
    // Start is called before the first frame update


    // Update is called once per frame
    private void FixedUpdate()
    {
        //Este codigo se encarga de mover las montañas del prefab
        Vector3 forwardMove = transform.right * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position +  forwardMove);
    }
}
