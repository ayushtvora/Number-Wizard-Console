using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int guess;
    private int max;
    private int min;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello! Welcome to the Number Wizard!");
        StartGame();
    }

    private void StartGame()
    {
        guess = 500;
        max = 1000;
        min = 1;
        Debug.Log("Please pick a number between " + min + " and " + max + " and I will try to guess it.");
        Debug.Log("Up Arrow = Higher; Down Arrow = Lower; Enter = Correct");
        Debug.Log("Guess: 500");
        max += 1;
    }

    // Update is called once per frame
    private void Update()
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
            Debug.Log("Yay! I did it!");
            StartGame();
        }
    }

    private void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Guess: " + guess);
    }
}