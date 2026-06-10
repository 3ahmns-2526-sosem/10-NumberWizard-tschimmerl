using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class NumberWizard : MonoBehaviour
{
    [SerializeField] private int min = 1;
    [SerializeField] private int max = 100;

    [SerializeField] private TMP_Text guessText;

    
    [SerializeField] private Button higherButton;
    [SerializeField] private Button lowerButton;
    [SerializeField] private Button correctButton;

    private int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        guess = (min + max) / 2;
        UpdateGuessDisplay();
    }

    public void OnHigherPressed()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnLowerPressed()
    {
        max = guess - 1;
        NextGuess();
    }

    
    public void OnCorrectPressed()
    {
        
        Debug.Log("I guessed your number!");

        
        if (guessText != null)
        {
            guessText.text = $"Win! {guess}";
        }

        
        if (higherButton != null) higherButton.interactable = false;
        if (lowerButton != null) lowerButton.interactable = false;
        if (correctButton != null) correctButton.interactable = false;
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        UpdateGuessDisplay();
    }

    void UpdateGuessDisplay()
    {
        if (guessText != null)
        {
            guessText.text = guess.ToString();
        }
    }
}