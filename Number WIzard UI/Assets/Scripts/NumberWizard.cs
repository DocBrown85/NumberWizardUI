using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }
    public void OnPressHigher()
    {
        EventSystem.current.SetSelectedGameObject(null);
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        EventSystem.current.SetSelectedGameObject(null);
        max = guess - 1;
        NextGuess();
    }

    public void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

}
