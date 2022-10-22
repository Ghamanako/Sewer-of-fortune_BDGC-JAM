using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjecGrabAble : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private Transform objectGrapPointTransform;
    float lerpSpeed = 10f;

    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }

    public void Grab(Transform objectGrapPointTransform)
    {
        this.objectGrapPointTransform = objectGrapPointTransform;
        objectRigidbody.useGravity = false;
        objectRigidbody.drag = 10;
    }

    public void Drop()
    {
        this.objectGrapPointTransform = null;
        objectRigidbody.useGravity = true;
        objectRigidbody.drag = 1;
    }

    private void FixedUpdate()
    {
        if (objectGrapPointTransform != null)
        {

            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrapPointTransform.position, Time.deltaTime * lerpSpeed);
            objectRigidbody.MovePosition(objectGrapPointTransform.position);
        }
    }
}
