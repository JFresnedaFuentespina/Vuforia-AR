using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ&list=RDdQw4w9WgXcQ&start_radio=1";
    public void OpenLink()
    {
        Application.OpenURL(url);
    }
}
