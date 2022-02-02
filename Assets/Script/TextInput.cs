using UnityEngine;
using TMPro;

public class TextInput : MonoBehaviour
{
    public TextMeshProUGUI texts;
    public TMP_InputField inputField;
    public void readText()
    {
        texts.text = ($"{inputField.text}!!! \n Исчезающий призрак выкрикнул ваше имя! \n Оставшиеся руины башни начали рушиться!");
    }
}
