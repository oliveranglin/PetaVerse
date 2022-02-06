using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        #region  example
        bool isSpacePressed = Input.GetKey(KeyCode.Space); //toggling states : is it currently pressed?
        bool justPressedSpace = Input.GetKeyDown(KeyCode.Space); // only once-activated trigger : aredid we start pressing it right now?
        bool justReleasedSpace = Input.GetKeyUp(KeyCode.Space); // did we stop pressing it right now?
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("space is pressed");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("we just pressed space");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("we just released space");
        }
        #endregion
        bool leftKey = Input.GetKey(KeyCode.LeftArrow);
        bool rightKey = Input.GetKey(KeyCode.RightArrow);
        bool uptKey = Input.GetKey(KeyCode.UpArrow);
        bool downKey = Input.GetKey(KeyCode.DownArrow);
        Vector3 movement = Vector3.zero;
        if (leftKey)
        {
            movement.x--;
        }
        if (rightKey)
        {
            movement.x++;
        }
        if (uptKey)
        {
            movement.z++;
        }
        if (downKey)
        {
            movement.z--;
        }
        this.transform.Translate(movement * speed * Time.deltaTime, Space.World); // <- better one
    }
    // keep it for physics
    void FixedUpdate()
    {
    }
}