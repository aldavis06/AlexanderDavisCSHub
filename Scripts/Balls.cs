using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            ContactPoint contact = collision.contacts[0];
            Vector3 impactDirection = contact.normal;
            float impactForce = collision.relativeVelocity.magnitude;

            Vector3 force = -impactDirection * impactForce * 50f;
            rb.AddForce(force, ForceMode.Impulse);
        }
    }
}
