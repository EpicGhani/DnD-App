using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class SetupScript : MonoBehaviour 
{
    public TMP_InputField charName, charClass, charLevel;
    public TMP_InputField minHp, maxHp, minMp, maxMp;
    public GameObject confirmation,fader;

    public void SaveStats()
    {
        //BASIC INFO
        PlayerPrefs.SetString("Name", charName.text);
        PlayerPrefs.SetString("Class", charClass.text);
        PlayerPrefs.SetInt("Level", int.Parse(charLevel.text));
        //NUMERICAL INFO
        PlayerPrefs.SetInt("MinHp", int.Parse(minHp.text));PlayerPrefs.SetInt("MaxHp", int.Parse(maxHp.text));
        PlayerPrefs.SetInt("MinMp", int.Parse(minMp.text));PlayerPrefs.SetInt("MaxMp", int.Parse(maxMp.text));

        PlayerPrefs.SetInt("FirstSetup", 1);
        confirmation.SetActive(false); 
        fader.SetActive(true);
    }
    public void Cancel()
    {
        confirmation.SetActive(false);
    }
    public void OpenConfirmation()
    {
        confirmation.SetActive(true);
    }        
}
