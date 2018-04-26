using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButon : MonoBehaviour {
    public void onStartGameButtonPress(string game)
    {
        SceneManager.LoadScene(game);
    }
}
