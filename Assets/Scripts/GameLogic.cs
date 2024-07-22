using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    private int randomNumber;
    public int MinValue;
    public int MaxValue;
    public Text gameLabel;
    public InputField userInput;
    public Button gameButton;
    private bool IsGameWon=false;
    // Start is called before the first frame update
    void Start()
    {
       
       ResetGame();
    }
    private void ResetGame()
    {
        
        if (IsGameWon)
        {
            gameLabel.text = "You Won! Guess the number between " + MinValue + " and " + (MaxValue + 1);
        IsGameWon = false;

        }else {
            gameLabel.text = "Guess the number between " + MinValue + " and " + (MaxValue + 1);
        }
        randomNumber = GetRandomNumber(MinValue, MaxValue);
        userInput.text = "";
         
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void OnButtonClick()
    {
        string userInputValue = userInput.text;
        if (userInputValue != "")
        {
            int answer = int.Parse(userInputValue);
            if (answer == randomNumber)
            {
                gameLabel.text = "Correct answer";
                //gameButton.interactable = false;
                IsGameWon = true;
                ResetGame();
                Debug.Log("Correct answer");

            }
            else if (answer > randomNumber)
            {
                gameLabel.text = "Try Lower!";
                Debug.Log("Try Lower!");
            }
            else
            {
                gameLabel.text = "Try Higher!";
                Debug.Log("Try Higher!");
            }
        } else
        {
            gameLabel.text = "Please enter a number";
            Debug.Log("Please enter a number");
        }



    }
    private int GetRandomNumber(int min, int max)
    {
        int random=Random.Range(min, max);
        return random;
    }
}
