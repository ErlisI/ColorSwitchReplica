using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public Rigidbody2D rB;
    public SpriteRenderer sR;

    public GameObject completeLvl;

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

      rB.isKinematic = true; //Starting with no jump

      playerRandomColor();

    }

    // Update is called once per frame
    void Update(){

      //Jumping everytime we press the space bar
      if(Input.GetButtonDown("Jump")){

        rB.isKinematic = false;

        rB.velocity = Vector2.up * jumpForce;

      }

    }

    void OnTriggerEnter2D (Collider2D collide) {

      //Chaning the color with the "Color Changer" object
      if(collide.tag == "ColorChanger"){

        Debug.Log("Color Changed");
        playerRandomColor();
        Destroy(collide.gameObject);
        return;

      }

      //Whenever we hit a different color than the player's we lose the game
      if(collide.tag != baseColor){

        Debug.Log("Game Over");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

      }

    }

    //Getting a random color
    void playerRandomColor() {

      var currentColor = (currColor)Random.Range(0, 4);

      //Changing the color if we already have that same color
      if(baseColor == (currentColor).ToString()){

        playerRandomColor();
        return;

      }

      //Getting different colors
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

    public void finishLine(){
      completeLvl.SetActive(true);
    }
}
