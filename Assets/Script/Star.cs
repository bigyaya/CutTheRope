using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Animations;

public class Star : MonoBehaviour
{
    public int value;
    //private Animator animator;



    private void Start()
    {
        //animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Candy"))
        {
            Destroy(gameObject);
            //animator.SetBool("IsExplode", true);
            StarCounter.instance.IncreaseStars(value);
        }
    }
}
