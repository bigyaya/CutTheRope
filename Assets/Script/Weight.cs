using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    #region Exposed

    public float distanceFromChainEnd = 0.6f;

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

    public void ConnectRopeEnd(Rigidbody2D endRB)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = endRB;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f, -distanceFromChainEnd);
    }

    #endregion



    #region Private & Protected

    #endregion
}
