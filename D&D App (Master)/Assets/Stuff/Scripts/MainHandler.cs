using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainHandler : MonoBehaviour
{
    public GameObject encounter;
    public CanvasGroup can;
    public Text charName, charClass, charLevel;
    public Slider HpSlider, MpSlider;
    public Text HpText, MpText;

    private int lvl, minHp, maxHp, minMp, maxMp;

    void Start()
    {
        charName.text = PlayerPrefs.GetString("Name");
        charClass.text = PlayerPrefs.GetString("Class");
        lvl = PlayerPrefs.GetInt("Level");
        charLevel.text = "Lvl: " + lvl;

        maxHp = PlayerPrefs.GetInt("MaxHp");
        HpSlider.maxValue = maxHp;
        minHp = PlayerPrefs.GetInt("MinHp");
        HpSlider.value = minHp;

        maxMp = PlayerPrefs.GetInt("MaxMp");
        MpSlider.maxValue = maxMp;
        minMp = PlayerPrefs.GetInt("MinMp");
        MpSlider.value = minMp;

        StartCoroutine("FadeIn");
    }

    void Update()
    {
        charLevel.text = "Lvl: " + lvl;

        HpSlider.maxValue = maxHp;
        HpSlider.value = minHp;
        HpText.text = HpSlider.value + " / " + HpSlider.maxValue;

        MpSlider.maxValue = maxMp;
        MpSlider.value = minMp;
        MpText.text = MpSlider.value + " / " + MpSlider.maxValue;
    }

    #region HPControl
    public void AddHP()
    {
        if (minHp < maxHp)
            minHp++;
        SaveStats();
    }
    public void MinusHP()
    {
        if (minHp > 0)
            minHp--;
        SaveStats();
    }
    #endregion
    #region MPControl
    public void AddMP()
    {
        if (minMp < maxMp)
            minMp++;
        SaveStats();
    }
    public void MinusMP()
    {
        if (minMp > 0)
            minMp--;
        SaveStats();
    }
    #endregion
    #region LevelControl
    public void AddLevel()
    {
        lvl++;
        SaveStats();
    }
    public void MinusLevel()
    {
        if (lvl > 0)
            lvl--;
        SaveStats();
    }
    #endregion


    void SaveStats()
    {
        PlayerPrefs.SetInt("Level", lvl);
        //NUMERICAL INFO
        PlayerPrefs.SetInt("MinHp", minHp); PlayerPrefs.SetInt("MaxHp", maxHp);
        PlayerPrefs.SetInt("MinMp", minMp); PlayerPrefs.SetInt("MaxMp", maxMp);
    }

    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(3);
        while (can.alpha < 1)
        {
            can.alpha += Time.deltaTime / 2;
            yield return null;
        }
        encounter.SetActive(false);
        yield return null;
    }

}
