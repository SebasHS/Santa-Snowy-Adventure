using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BossGotHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Grinch hit: " + collision.name);
        if (collision.name == "Bomb(Clone)")
        {
            ToyManager.Instance.grinchHealth--;
            if (ToyManager.Instance.grinchHealth <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(3);
            }
        }
    }
}
