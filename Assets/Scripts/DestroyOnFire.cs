using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyOnFire : MonoBehaviour
{
    public CarryingObject carrier;
    public UnityEvent unityEvent;

    public void Start()
    {
        if(unityEvent == null)
        {
            unityEvent = new UnityEvent();
        }
    }

    public void Destroy()
    {
        if (carrier == null)
        {
            gameObject.SetActive(false);
            unityEvent.Invoke();
        }
        else
        {
            GameObject beingCarried = carrier.currentObject ? carrier.currentObject.gameObject : null;
            if (!Object.Equals(beingCarried, gameObject))
            {
                gameObject.SetActive(false);
                unityEvent.Invoke();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (DamageCircle.IsOutSideCircle(transform.position))
        {
            gameObject.SetActive(false);
            unityEvent.Invoke();
        }
    }
}
