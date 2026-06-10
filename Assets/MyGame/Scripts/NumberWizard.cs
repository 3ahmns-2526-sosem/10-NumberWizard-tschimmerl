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

    
    void UpdateGuessDisplay()
    {
        if (guessText != null)
        {
            guessText.text = guess.ToString();
        }
    }
}