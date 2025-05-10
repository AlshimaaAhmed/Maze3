using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{
    public void Level_One_Open()
    {
        PlayerManager.Instance.playerData.currentLevel = 1;
        PlayerData.SaveData(PlayerManager.Instance.playerData);
        SceneManager.LoadScene("level 1");
    }

    public void Level_Two_Open()
    {
        PlayerManager.Instance.playerData.currentLevel = 2;
        PlayerData.SaveData(PlayerManager.Instance.playerData);
        SceneManager.LoadScene("level 2");
    }

    public void Level_Three_Open()
    {
        PlayerManager.Instance.playerData.currentLevel = 3;
        PlayerData.SaveData(PlayerManager.Instance.playerData);
        SceneManager.LoadScene("level 3");
    }
}
