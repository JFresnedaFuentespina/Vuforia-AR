using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DetectPointerEventsDance : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public Animator animator;
    public void OnPointerDown(PointerEventData eventData)
    {
        animator.SetTrigger("Dance");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Color color = GetComponent<Renderer>().material.color;
        // color.a = 1f;
        // GetComponent<Renderer>().material.color = color;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Ray ray = Camera.main.ScreenPointToRay(eventData.position);
        // RaycastHit hitData;

        // if (Physics.Raycast(ray, out hitData, 1000, LayerMask.GetMask("Surface")))
        // {

        //     worldPosition = hitData.point;
        //     transform.position = worldPosition;
        //     if (textPosition != null)
        //     {
        //         textPosition.text = transform.name + " " + transform.position;
        //     }
        // }
    }
}
