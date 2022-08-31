using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameplay : MonoBehaviour
{
    [SerializeField] private int minValue;
    [SerializeField] private int maxValue;
    [SerializeField] private TextMeshProUGUI guessText;

    private int guess;
    void Start() 
    {
      NextGuess();   
    }
    public void cum()
    {
       minValue = guess + 1;
       NextGuess();
    }
    public void sex()
    {
        maxValue = guess - 1 ;
        NextGuess();
    }
    public void NextGuess()
    {
        guess = Random.Range(minValue, maxValue + 1);
        guessText.text = guess.ToString();
    }
    
}
