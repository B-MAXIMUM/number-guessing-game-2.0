using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour
{
    [SerializeField] private int guess;
    [SerializeField] private int minValue;
    [SerializeField] private int maxValue;
    // Start is called before the first frame update
    void Start()
    {
       StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        cum();
    }
    public void OnPressHigher()
    {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
    }
    public void OnPressLower()
    {
            maxValue = guess;
            guess = (maxValue +minValue) / 2;
    }
    public void NextGuess()
    {

    }
    void StartGame()
    {
        guess = 5;
        maxValue = 10;
        minValue = 1;
        
        maxValue = maxValue+1;
    }
    void cum()
    {
         if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            guess = (maxValue +minValue) / 2;
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("HAHAHA I am so smart it was " +guess+ " you dumass");
            Debug.Log("");
            StartGame();
        }
    }
}
