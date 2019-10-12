using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public float thust;
    private Rigidbody sphereBody;
    void Start()
    {
        sphereBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space)){
            sphereBody.isKinematic = false ;

            sphereBody.velocity = new Vector3( 0, 0 );
            sphereBody.AddForce( new Vector3( 0, thust ), ForceMode.Impulse);

        }
    }
}
