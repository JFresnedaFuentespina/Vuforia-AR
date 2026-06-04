using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PathsManager : MonoBehaviour
{
    public Button especializacionButton;
    public Button aulatecaButton;
    public GameObject especializacionPath;
    public GameObject aulatecaPath;
    public TextMeshProUGUI descriptionText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        especializacionButton.onClick.AddListener(ShowEspecializacionPath);
        aulatecaButton.onClick.AddListener(ShowAulatecaPath);
    }

    void ShowEspecializacionPath()
    {
        especializacionPath.SetActive(true);
        aulatecaPath.SetActive(false);
        descriptionText.text = "Ruta a Especialización: " + especializacionPath.activeSelf;
    }

    void ShowAulatecaPath()
    {
        especializacionPath.SetActive(false);
        aulatecaPath.SetActive(true);
        descriptionText.text = "Ruta a Aulateca: " + aulatecaPath.activeSelf;
    }
}
