using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float timeStart = 60;
    public Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString();
        timeStart = 60;
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();

        if((timeStart == 0) || (timeStart < 0))
        {
            SceneManager.LoadScene("game over");
        }
    }
}
