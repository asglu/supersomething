using UnityEngine;
using System.Collections;

public class LookAtScript : MonoBehaviour 
{
    public Transform Target;
    
    
    void Update ()
    {
        Vector3 relativePos = Target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}