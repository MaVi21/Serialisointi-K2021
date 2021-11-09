using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string sceneToLoad;
    private Text nameText;
    private Text moneyText;
    
    void Start()
    {
        nameText = GameObject.Find("SceneNameText").GetComponent<Text>();
        nameText.text = "Scene " + SceneManager.GetActiveScene().name;

        Debug.Log("Scene " + SceneManager.GetActiveScene().name + " loaded");
        Debug.Log("Player's money: " + PlayerInfo.Money);

        moneyText = GameObject.Find("MoneyText").GetComponent<Text>();
        moneyText.text = "Player's money: " + PlayerInfo.Money;
    }

    public void OnMoneyButtonClicked()
    {
        PlayerInfo.Money++;
        Debug.Log("Money updated to: " + PlayerInfo.Money);
        moneyText.text = "Player's money: " + PlayerInfo.Money;
    }

    public void OnLoadSceneButtonClicked()
    {
       // Scene scene = SceneManager.GetActiveScene();

       // if(scene.name == "StaticClass1")
            SceneManager.LoadScene(sceneToLoad);
       // else
         //   SceneManager.LoadScene("StaticClass1");
    }
}
