using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour
{
    [SerializeField] float delaysec =2f;

    ScoreKeeper scoreKeeper;

     void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void LoadGame()
    {
        scoreKeeper.ResetScore();
        SceneManager.LoadScene("Game Scene");
    }

    public void LoadShip()
    {
        SceneManager.LoadScene("Ship");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Main Menu");
    }   

    public void OnGameOver()
    {
        StartCoroutine(WaitAndLoad("GameOver",delaysec));
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator WaitAndLoad(string sceneName,float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
