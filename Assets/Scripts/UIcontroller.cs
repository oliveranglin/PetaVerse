using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    float _countdownTime = 4;  // Will be rounded down & actually start at 3.
    bool _countdownRunning;    // Is countdown running at the moment? Will be false by default.
    Text _countdownText;       // Text element of UI to show the countdown value.
    GameObject _healthBar;

    void Start()
    {
        _countdownText = GameObject.Find("countdownText").GetComponent<Text>();

        // Get the button by its name and assign click listener to it. When the button is clicked, Play() method is called.
        GameObject.Find("play").GetComponent<Button>().onClick.AddListener(Play);
        GameObject.Find("exit").GetComponent<Button>().onClick.AddListener(Exit);
        _healthBar = GameObject.Find("game");
        _healthBar.SetActive(false);
    }

    // This will be called after the "buttonPlay" is clicked
    void Play()
    {
        _countdownRunning = true;

        // Countdown is running => hide the Play button
        GameObject.Find("play").SetActive(false);
        GameObject.Find("exit").SetActive(false);
    }

    void Update()
    {
        // If countdown is running
        if (_countdownRunning)
        {
            // Decrement countdown by time elapsed from last frame
            _countdownTime -= Time.deltaTime;

            // Show countdown in the text element of UI (rounded down by Floor)
            _countdownText.text = Mathf.Floor(_countdownTime).ToString();

            // Countdown ended
            if (_countdownTime < 1)
            {
                // Hide background
                GameObject.Find("startBackground").SetActive(false);  

                //show health bar
                 _healthBar.SetActive(true);              
                // Run game
                GameController.gameRunning = true;

                // Stop countdown
                _countdownRunning = false;
            }
        }
    }

    void Exit(){
        Application.Quit();
       // #if UNITY_EDITOR
        //UnityEditor.EditorApplication.isPlaying = false;
        //#endif
    }

}


