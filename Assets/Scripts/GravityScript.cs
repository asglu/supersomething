using UnityEngine;
using System.Collections;

public class GravityScript : MonoBehaviour 
{
    public Transform target;
    
    
    void Update () 
    {
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        
        Quaternion current = transform.localRotation;
        
        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        transform.Translate(0, 0, 600 * Time.deltaTime);
        transform.localRotation = rotation;
    }
    
	//crazy warmhole rotation
//	void Update () 
//	{
//		Vector3 relativePos = target.position - transform.position;
//		Quaternion rotation = Quaternion.LookRotation(relativePos);
//		
//		Quaternion current = transform.localRotation;
//		
//		transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
//		transform.Translate(0, 0, 600 * Time.deltaTime);
//		transform.rotation = rotation;
//	}
}