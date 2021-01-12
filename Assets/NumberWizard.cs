using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame() {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a random number");
        Debug.Log("The highest number you can choose is " + max);
        Debug.Log("The lowest number you can choose is " + min);
        Debug.Log("Tell me if your number is lower or higher than " + guess);
        Debug.Log("Up key = higher, down key = lower, return = correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            min = guess;
            NextGuess();
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Nailed it!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min)/2;
        Debug.Log("Is it higher or lower than " + guess + "?");
    }
}
