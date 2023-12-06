using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float MovementSpeed=5;
    [SerializeField]
    private GameObject bombPrefab;
    [SerializeField]
    private Transform hand;
    private Vector3 direction = Vector3.zero;
    private CharacterController characterController;

    public Animator santa;

    

    
    //
    


    // Start is called before the first frame update
    void Awake()
    {
        //Move
        characterController = GetComponent<CharacterController>();
        GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        characterController.Move(
           direction.normalized*Time.deltaTime*MovementSpeed
        );
        characterController.Move(Vector3.down * Time.deltaTime * 9.8f);

    }

    
    private void OnMove(InputValue value)
    {
        var data = value.Get<Vector2>();
        direction = new Vector3(
            0f,
            0f,
            data.x
        );
    }
    private void OnFire(InputValue value)
    {
        // Acceder al Animator y establecer el parámetro IsThrowing a true
        santa.SetBool("IsThrowing", true);
        StartCoroutine(ResetThrowingParameter(0.7f));
        StartCoroutine(ThrowBall(0.4f));
    }
    private IEnumerator ResetThrowingParameter(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        santa.SetBool("IsThrowing", false);
    }

    private IEnumerator ThrowBall(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        //Instanciar bombPrefab
    }

    private void OnLook(InputValue value)
    {
        
    }
}