using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfLogic : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play("IdleSadElf");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
