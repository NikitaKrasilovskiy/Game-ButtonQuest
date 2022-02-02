using UnityEngine;
using TMPro;

public class TextInputCode : MonoBehaviour
{
    public TextMeshProUGUI text1, text2, text3;
    float code1, code2, code3;
    public GameObject[] buttons;
    public void Sword()
    {
       code1  -= 2; code2 -= 2; code3 += 2;
    }
    public void Pick()
    {
        code1 += 1; code2 += 1; code3 -= 1;
    }
    public void Head()
    {
        code1 += 1; code2 -= 0; code3 -= 1;
    }
    private void Update()
    {
        if (code1 < 0) { code1 = 0; }
        else if (code1 > 10) { code1 = 10; }

        if (code2 < 0) { code2 = 0; }
        else if (code2 > 10) { code2 = 10; }

        if (code3 < 0) { code3 = 0; }
        else if (code3 > 10) { code3 = 10; }

        text1.text = code1.ToString();
        text2.text = code2.ToString();
        text3.text = code3.ToString();

        if (code1 == 5 && code2 == 5 && code3 == 5)
        {
            for (int i = 0; i < 14; i++)
            { buttons[i].SetActive(false); }

            buttons[14].SetActive(true);
            buttons[15].SetActive(true);
            buttons[16].SetActive(true);
            buttons[17].SetActive(true);
        }
    }
}

