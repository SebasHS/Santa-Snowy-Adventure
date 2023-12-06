using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyMove : MonoBehaviour
{
  public float speed = 27;
  public Rigidbody rb;
  [SerializeField] public int x, y, z;
  void Start()
  {

  }

  private void FixedUpdate()
  {
    //Mover los toys //Ver si se mueven igual que la montaña
    /*Vector3 forwardMove = transform.right * speed * Time.fixedDeltaTime;
    rb.MovePosition(rb.position +  forwardMove);*/
    //Vector3 vex = new Vector3(x, y, z) ;

    //transform.Translate(x, y, z);

  }
  void Update()
  {
    /*Vector3 forwardMove = transform.right * speed * Time.fixedDeltaTime;
    transform.Translate(forwardMove * speed * Time.deltaTime);
    Debug.Log("Toy move");*/
  }

  void OnTriggerEnter(Collider collision)
  {
    if(this.name == "Cookie" && collision.name == "Santa")
    {
      Debug.Log("Cookie - 1UP");
      ToyManager.Instance.OneUP();
      Destroy(gameObject);
    }
    else if (collision.name == "Santa")
    {
      Debug.Log("Entra: " + this.name);
      ToyManager.Instance.QuitardeLista(this.name);
      Debug.Log("Destroy -----> " + this.name);
      Destroy(gameObject);
    }
  }
}
