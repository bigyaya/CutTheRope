using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    #region Exposed

    #endregion

	

    #region Unity Lifecycle
void Awake()
{

}

 void Start()
    {

    }

 void Update()
    {

    }

void FixedUpdate()
{

}
    #endregion



    #region Methods

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1) ;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    #endregion



    #region Private & Protected

    #endregion
}
