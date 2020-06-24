using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject LevelMenuUI;
    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

public void Resume (){
    PauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    GameIsPaused = false;
}

void Pause (){
    PauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;
}

public void LoadLevelMenu(){
    PauseMenuUI.SetActive(false);
    LevelMenuUI.SetActive(true);

}

public void QuitGame(){
    Debug.Log("Quitting game...");
}

public void LoadLevel2(){
    SceneManager.LoadScene("Level 2");
}
public void LoadLevel1(){
    SceneManager.LoadScene("Level 1");
}public void LoadLevel3(){
    SceneManager.LoadScene("Level 3");
}public void LoadLevel4(){
    SceneManager.LoadScene("Level 4");
}public void LoadLevel5(){
    SceneManager.LoadScene("Level 5");
}
}

