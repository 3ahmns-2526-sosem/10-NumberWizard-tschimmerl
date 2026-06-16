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

    
    [SerializeField] private Button restartButton;

    
    private int startMin;
    private int startMax;
    private int guess;

    private void Start()
    {
        
        startMin = min;
        startMax = max;

        StartGame();
    }

    private void StartGame()
    {
        
        min = startMin;
        max = startMax;

        
        if (higherButton != null) higherButton.interactable = true;
        if (lowerButton != null) lowerButton.interactable = true;
        if (correctButton != null) correctButton.interactable = true;
        if (restartButton != null) restartButton.gameObject.SetActive(false);

        NextGuess();
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
            guessText.text = guess.ToString() + " - Win!";
        }

        
        if (higherButton != null) higherButton.interactable = false;
        if (lowerButton != null) lowerButton.interactable = false;
        if (correctButton != null) correctButton.interactable = false;

        
        if (restartButton != null) restartButton.gameObject.SetActive(true);
    }

    
    public void OnRestartPressed()
    {
        StartGame();
    }

    private void NextGuess()
    {
        guess = (min + max + 1) / 2;
        UpdateGuessDisplay();
    }

    private void UpdateGuessDisplay()
    {
        if (guessText != null)
        {
            guessText.text = guess.ToString();
        }
    }
}