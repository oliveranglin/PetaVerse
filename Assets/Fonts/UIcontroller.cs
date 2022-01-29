using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("buttonPlay").GetComponent<Button>().onClick.AddListener(Play);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("buttonPlay").SetActive(false);
    }
}
