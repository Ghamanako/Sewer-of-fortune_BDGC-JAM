using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPick : MonoBehaviour
{
    [SerializeField] private Transform PlayerCameraTransform;
    [SerializeField] private Transform ObjectGrabPoints;
    [SerializeField] private LayerMask PickUpLayerMask;

    private ObjecGrabAble objecGrabAble;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (objecGrabAble == null)
            {
                float PickUpDistance = 2f;
                if (Physics.Raycast(PlayerCameraTransform.position, PlayerCameraTransform.forward, out RaycastHit raycastHit, PickUpDistance)) ;
                {
                    if (raycastHit.transform.TryGetComponent(out objecGrabAble))
                    {
                        objecGrabAble.Grab(ObjectGrabPoints);
                    }
                    Debug.Log(objecGrabAble);
                }

            }
            else
            {
                objecGrabAble.Drop();
                objecGrabAble = null;
            }


        }
    }
}
