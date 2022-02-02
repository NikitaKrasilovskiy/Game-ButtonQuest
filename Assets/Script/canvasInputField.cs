using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class canvasInputField : MonoBehaviour
{
    public TextMeshProUGUI counter;
    public TMP_InputField inputField;
    public String answer;
    public void dead()
    {
        SceneManager.LoadScene("Dead");
    }
    public void readText()
    {
        if (inputField.text == answer)
        {
            counter.text = "Правильно!";
        }
        else
        {
            dead();
        }
    }
}
