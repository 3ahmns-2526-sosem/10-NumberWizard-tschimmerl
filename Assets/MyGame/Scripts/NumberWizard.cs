using UnityEngine;
using TMPro; 

public class NumberWizard : MonoBehaviour
{
    
    [SerializeField] private int min = 1;
    [SerializeField] private int max = 100;

    
    [SerializeField] private TMP_Text guessText;

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

    void NextGuess()
    {
        
        guess = (min + max) / 2;

        
        UpdateGuessDisplay();
    }

   
    public void OnLowerPressed()
    {
        
        max = guess - 1;

        
        NextGuess();
    }

    void UpdateGuessDisplay()
    {
        if (guessText != null)
        {
            guessText.text = guess.ToString();
        }
    }
}