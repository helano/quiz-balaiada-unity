using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class BasicCommands : MonoBehaviour {

    public void loadScene(string sceneName)
    {
		//  SceneManager.LoadScene(sceneName);
		Application.LoadLevel("title");
		Application.LoadLevel("themes");
		Application.LoadLevel("T1");
		Application.LoadLevel("scores");    }

}
