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

    public AudioSource bg;

    

    
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
    private bool isThrowing = false;
    private void OnFire(InputValue value)
    {
        // Acceder al Animator y establecer el parámetro IsThrowing a true
        santa.SetBool("IsThrowing", true);
        StartCoroutine(ResetThrowingParameter(0.7f));
        StartCoroutine(ThrowBall());
    }
    private IEnumerator ResetThrowingParameter(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        santa.SetBool("IsThrowing", false);
    }

    private IEnumerator ThrowBall()
    {
        // Marcar que estamos en el proceso de lanzamiento
        isThrowing = true;
        yield return new WaitForSeconds(0.4f);
        //Instanciar bombPrefab
        // Obtener la posición del mouse en el mundo
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            // Calcular la dirección hacia el punto seleccionado
            Vector3 throwDirection = (hit.point - hand.position).normalized;
            // Ajustar el ángulo de lanzamiento
            float throwAngle = 10f; // Ajusta el ángulo según sea necesario
            // Calcular la dirección con el ángulo de lanzamiento
            throwDirection = Quaternion.AngleAxis(throwAngle, Vector3.Cross(throwDirection, Vector3.up)) * throwDirection;
            // Instanciar el bombPrefab con posición relativa al padre (hand)
            GameObject bomb = Instantiate(bombPrefab, hand.position, Quaternion.identity);

            // Obtener el componente Rigidbody del bombPrefab
            Rigidbody bombRb = bomb.GetComponent<Rigidbody>();
            // Aplicar fuerza al Rigidbody para lanzar la bomba hacia el punto seleccionado con ángulo
            float throwForce = 20f; // Ajusta la fuerza según sea necesario
            bombRb.AddForce(throwDirection * throwForce, ForceMode.Impulse);
        }
        yield return new WaitForSeconds(0.2f);
        // Marcar que hemos terminado el proceso de lanzamiento
        isThrowing = false;
        // Desactivar la animación
        santa.SetBool("IsThrowing", false);
    }

    private void OnLook(InputValue value)
    {
        
    }
}