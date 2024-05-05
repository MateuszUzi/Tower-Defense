using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

    public Transform target;
    public float range = 15f;

    private void Start() {

    }

    void update() {
    }

    private void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
        
    }


}