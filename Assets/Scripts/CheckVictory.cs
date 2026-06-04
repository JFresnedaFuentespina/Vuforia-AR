using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckVictory : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<DetectPointerEventsGuess> detectPointerEventsGuesses;
    public TextMeshProUGUI victoryText;
    public GameObject victoryPanel;
    public int totalToGuess = 0;
    public int guessedRight = 0;

    void Start()
    {
        totalToGuess = detectPointerEventsGuesses.Count;
    }
    public void CheckIfAllRight()
    {
        if (guessedRight >= totalToGuess)
        {
            victoryText.text = "Congratulations! You guessed all right!";
            victoryPanel.GetComponent<Image>().color = Color.green;
        }
    }

}
