using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollision : MonoBehaviour
{
    #region Exposed

    #endregion

	

    #region Unity Lifecycle
void Awake()
{

}

 void Start()
    {

    }

 void Update()
    {

    }

void FixedUpdate()
{

}
    #endregion



    #region Methods
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Candy"))
        {
            Explode();
        }
    }

    private void Explode()
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, 1f); // Adaptez la durée de vie de l'explosion en fonction de la durée de l'animation
        Destroy(gameObject);
    }
    #endregion



    #region Private & Protected
    public GameObject explosionPrefab;
    #endregion
}
