using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    #region Exposed
    public Rigidbody2D hook;
    public GameObject linkPrefab;
    public int links = 7;
    public Weight weigth;


    #endregion



    #region Unity Lifecycle
    void Awake()
{

}

 void Start()
    {

        GenerateRope();

    }

	#endregion



	#region Methods

	void GenerateRope()
	{
		Rigidbody2D previousRB = hook.GetComponent<Rigidbody2D>();
		for (int i = 0; i < links; i++)
		{
			GameObject link = Instantiate(linkPrefab, transform);
			HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
			joint.connectedBody = previousRB;

            if (i < links - 1)
            {
                previousRB = link.GetComponent<Rigidbody2D>();
            }
            else
            {
                weigth.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }

        }
	}

	#endregion



	#region Private & Protected

	#endregion
}
