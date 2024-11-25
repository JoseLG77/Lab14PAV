using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("bullet")) 
        {
            Destroy(col.gameObject); 


            animator.SetTrigger("FadeOut");


            Destroy(gameObject, 0f); 
        }
    }
}