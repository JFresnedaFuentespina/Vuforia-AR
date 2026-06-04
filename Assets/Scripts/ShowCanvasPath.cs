using UnityEngine;

public class ShowCanvasPath : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject canvasPath;
    void Start()
    {
        
    }

    public void ShowPath()
    {
        canvasPath.SetActive(true);
    }

    public void hidePath()
    {
        canvasPath.SetActive(false);
    }
}
