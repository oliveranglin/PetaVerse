using UnityEngine;

public class GameController : MonoBehaviour
{
    public static bool gameRunning;

    void Update()
    {
        if (!gameRunning)
            return;

        // Catch the user input here - for example left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Do the jump or other stuff
        }
    }
}

