using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour
{
    private int guess = 5;
    private int minValue = 1;
    private int maxValue = 10;
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
    void StartGame()
    {
        guess = 5;
        maxValue = 10;
        minValue = 1;

        Debug.Log("welcome to the sexy number guessing game");
        Debug.Log("the number range is from " + minValue + " to " +maxValue+ "");
        Debug.Log("i will guess a number and you say if it is higher or lower then : " +guess+ "");
        Debug.Log("push arrow keys depending on higher(up arrow) or lower(down arrow) and enter if correct");
        maxValue = maxValue+1;
    }
    void cum()
    {
         if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("is this it or is it higher or lower than: " + guess);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            guess = (maxValue +minValue) / 2;
            Debug.Log("is it higher or lower or am i right: " + guess);
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("HAHAHA I am so smart it was " +guess+ " you dumass");
            Debug.Log("");
            StartGame();
        }
    }
}
