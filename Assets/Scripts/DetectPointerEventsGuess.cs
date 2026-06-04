using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DetectPointerEventsGuess : MonoBehaviour
{
    public string nameToGuess;
    public TMP_InputField inputField;
    public GameObject panel;
    public Button sendButon;
    public bool isRight = false;
    public bool hasGuessed = false;

    public CheckVictory checkVictory;

    void Start()
    {
        sendButon.onClick.AddListener(Guess);
        checkVictory = GameObject.Find("Checker").GetComponent<CheckVictory>();
    }

    public void Guess()
    {
        if (hasGuessed) return;

        string guessed = inputField.text;
        guessed = guessed.Trim();
        guessed = guessed.ToLower();

        if (guessed.Equals(nameToGuess))
        {
            Debug.Log("Correct!");
            panel.GetComponent<Image>().color = Color.green;
            isRight = true;
            checkVictory.guessedRight++;
        }
        else
        {
            Debug.Log("Wrong! Try again.");
            panel.GetComponent<Image>().color = Color.red;
        }

        hasGuessed = true;
        checkVictory.CheckIfAllRight();
    }
}
