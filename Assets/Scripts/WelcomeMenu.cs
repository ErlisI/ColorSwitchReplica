using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeMenu : MonoBehaviour
{

    public void StartGame() {

      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
