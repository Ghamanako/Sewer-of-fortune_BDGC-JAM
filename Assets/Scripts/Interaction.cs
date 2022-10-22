using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class Interaction : MonoBehaviour
{
    [SerializeField] LayerMask interacbleLayer = 8;
    public CanInteract canInteract;
    public Image interactImage;
    public Sprite defaultIcon;
    public Vector2 defaultIconSize;
    public Sprite defauultInteractIcon;
    public Vector2 defaultInteractionIconsize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward,out hit, 2, interacbleLayer))
        {
            if (hit.collider.GetComponent<CanInteract>() != false)
            {
                if (canInteract == null || canInteract.ID != hit.collider.GetComponent<CanInteract>().ID)
                {
                    canInteract = hit.collider.GetComponent<CanInteract>();
                    interactImage.sprite = canInteract.interactIcon;
                }

                if (canInteract.interactIcon != null)
                {
                    interactImage.sprite = canInteract.interactIcon;
                    if (canInteract.iconSize == Vector2.zero)
                    {
                        interactImage.rectTransform.sizeDelta = defaultInteractionIconsize;
                    }
                    else
                    {
                        interactImage.rectTransform.sizeDelta = canInteract.iconSize;
                    }
                }

                else
                {
                    interactImage.sprite = defauultInteractIcon;
                    interactImage.rectTransform.sizeDelta = defaultInteractionIconsize;
                }
               
                if (Input.GetKeyDown(KeyCode.E))
                {
                    canInteract.onInteract.Invoke();
                }
            }
        }
        else
        {
            if (interactImage.sprite != defaultIcon)
            {
                interactImage.sprite = defaultIcon;
                interactImage.rectTransform.sizeDelta = defaultIconSize;
            }
        }
    }
}
