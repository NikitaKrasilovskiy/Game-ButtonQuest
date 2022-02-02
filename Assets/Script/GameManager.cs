using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button buttonHelper, buttonWarrior;
    public GameObject buttonRedirect, buttonSword;
    public TextMeshProUGUI warriorText, helperText, resursText, raidText, supportText;
    public int warriorNumber, helperNumber, resursNumber;
    public int warriorCount, helperCount, nextraid, raidIncrease;
    private float helperTimer = -2, warriorTimer = -2, raidTimer = 2, raidMaxTimer = 40;
    public ImageTimer resurs, support;
    public Image warriorImage, helperImage, resurseImage, raidImage;
    private int helperCreateTimer = 5, helperCreate = 2, warriorCreateTimer = 5, warriorCreate = 4;
    void Start()
    {
        UpdateText();
        raidTimer = raidMaxTimer;
    }
    void Update()
    {
        raidTimer -= Time.deltaTime;
        raidImage.fillAmount = raidTimer / raidMaxTimer;
        raidText.text = nextraid.ToString();

        supportText.text = "+" + (helperNumber * helperCount) + "\n" + "-" + warriorNumber * warriorCount;

        if (raidTimer <= 0)
        {
            raidTimer = raidMaxTimer;
            warriorNumber -= nextraid;
            nextraid *= raidIncrease;
        }

        if (nextraid >= 16)
        {
            buttonRedirect.SetActive(true);
        }
        else if (nextraid >= 32)
        { buttonSword.SetActive(true); }

        if (resurs.tick)
        { resursNumber += helperNumber * helperCount; }

        if (support.tick)
        { resursNumber -= warriorNumber * warriorCount; }

        if (helperTimer > 0)
        {
            helperTimer -= Time.deltaTime;
            helperImage.fillAmount = helperTimer / helperCreateTimer;
        }
        else if (helperTimer > -1)
        {
            helperImage.fillAmount = 0;
            buttonHelper.interactable = true;
            helperNumber += 1;
            helperTimer = -2;
        }

        if (warriorTimer > 0)
        {
            warriorTimer -= Time.deltaTime;
            warriorImage.fillAmount = warriorTimer / warriorCreateTimer;
        }
        else if (warriorTimer > -1)
        {
            warriorImage.fillAmount = 0;
            buttonWarrior.interactable = true;
            warriorNumber += 1;
            warriorTimer = -2;
        }
        if (warriorNumber < 0 || resursNumber < 0)
        { SceneManager.LoadScene("Dead"); }
        else if (nextraid == 64)
        { }

        UpdateText();
    }
    public void CreateHelper()
    {
        if (resursNumber >= 2)
        {
            resursNumber -= helperCreate;
            helperTimer = helperCreateTimer;
            buttonHelper.interactable = false;
        }
    }
    public void CreateWarrior()
    {
        if (resursNumber >= 4)
        {
            resursNumber -= warriorCreate;
            warriorTimer = warriorCreateTimer;
            buttonWarrior.interactable = false;
        }
    }
    public void CreateRedirect()
    {
        if (helperNumber > 1)
        {
            warriorNumber += 1;
            helperNumber -= 2;
        }
    }
    public void CreateSword()
    {
        warriorNumber *= 2;
        buttonSword.SetActive(false);
    }
    private void UpdateText()
    {
        resursText.text = resursNumber.ToString();
        warriorText.text = warriorNumber.ToString();
        helperText.text = helperNumber.ToString();
    }
}
