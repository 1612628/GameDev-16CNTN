using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCheck : MonoBehaviour
{

    private ReaperManWalking reaperMan;

    // Start is called before the first frame update
    void Start()
    {
        reaperMan = gameObject.GetComponentInParent<ReaperManWalking>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        reaperMan.grounded = true;   
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        reaperMan.grounded = true;    
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        reaperMan.grounded = false;
    }
}
