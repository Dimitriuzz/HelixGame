using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class OneColliderTrigger : MonoBehaviour

    
{
    private Collider lastCollider;

    protected virtual void OnOneColliderEnter(Collider other) { }
    private void OnTriggerEnter(Collider other)
    {
        if (lastCollider != null && lastCollider != other) return;
        lastCollider = other;
        OnOneColliderEnter(other);
    }

    private void OnTriggerExit(Collider other)
    {
        if (lastCollider==other) lastCollider=null;
    }

}
