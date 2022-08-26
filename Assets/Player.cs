using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public Rigidbody2D rB;
    public SpriteRenderer sR;

    public float jumpForce = 10f;
    string baseColor;

    public Color cCyan;
    public Color cYellow;
    public Color cPink;
    public Color cPurple;

    public enum currColor{
      Cyan,
      Yellow,
      Pink,
      Purple
    }


    void Start() {

      if(Input.GetButtonDown("Jump")){

        rB.velocity = Vector2.up * jumpForce;

      }

      playerRandomColor();

    }

    // Update is called once per frame
    void Update(){

      if(Input.GetButtonDown("Jump")){

        rB.velocity = Vector2.up * jumpForce;

      }

    }

    void OnTriggerEnter2D (Collider2D collide) {

      if(collide.tag == "ColorChanger"){

        playerRandomColor();
        Destroy(collide.gameObject);
        return;

      }

      if(collide.tag != baseColor){

        Debug.Log("Game Over");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

      }

    }

    void playerRandomColor() {

      var currentColor = (currColor)Random.Range(0, 4);

      if(baseColor == (currentColor).ToString()){

        playerRandomColor();
        return;

      }

      switch(currentColor){

        case currColor.Cyan: {
          baseColor = "Cyan";
          sR.color = cCyan;
          break;
        }

        case currColor.Yellow: {
          baseColor = "Yellow";
          sR.color = cYellow;
          break;
        }

        case currColor.Pink: {
          baseColor = "Pink";
          sR.color = cPink;
          break;
        }

        case currColor.Purple: {
          baseColor = "Purple";
          sR.color = cPurple;
          break;
        }
      }
    }
}
