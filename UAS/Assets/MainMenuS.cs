using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuS : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
         SceneManager.LoadScene("SampleScene");
    }
    public void LevelGame()
    {
         SceneManager.LoadScene("Level");
    }
    public void EasyGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MediumGame()
    {
        SceneManager.LoadScene("Medium");
    }
    public void HardGame()
    {
        SceneManager.LoadScene("Hard");
    }
    public void Multiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }
}
