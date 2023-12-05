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
    private Vector3 direction = Vector3.zero;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Awake()
    {
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
        
    }
    private void OnLook(InputValue value)
    {
        
    }
}
