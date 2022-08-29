using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if(player.position.y > transform.position.y){
          transform.position = new Vector3 (0f, player.position.y, -10f);
        }
        if(player.transform.position.y < - 10f || transform.position.y < -10f){
          Debug.Log("Game Over");
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
