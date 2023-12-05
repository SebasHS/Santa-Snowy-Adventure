using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyMove : MonoBehaviour
{
  public float speed = 15;
  public Rigidbody rb;
  [SerializeField] public int x, y, z;
  void Start()
  {
    speed = 14;
  }
  
  private void FixedUpdate()
  {
    //Mover los toys //Ver si se mueven igual que la montaña
    /*Vector3 forwardMove = transform.right * speed * Time.fixedDeltaTime;
    rb.MovePosition(rb.position +  forwardMove);*/
    //Vector3 vex = new Vector3(x, y, z) ;
    Vector3 forwardMove = transform.right * speed * Time.fixedDeltaTime;
    transform.Translate(forwardMove * speed * Time.deltaTime);
    //transform.Translate(x, y, z);

  }
}