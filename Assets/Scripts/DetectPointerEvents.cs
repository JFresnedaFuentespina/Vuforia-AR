using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DetectPointerEvents : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public TextMeshProUGUI textPosition;
    public GameObject textDisplay;
    Vector3 worldPosition;
    public void OnPointerDown(PointerEventData eventData)
    {
        textDisplay.SetActive(textDisplay.activeSelf ? false : true);
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
