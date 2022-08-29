using UnityEngine;

public class FinishTrigger : MonoBehaviour
{

    public Player p;

    void OnTriggerEnter() {

      p.finishLine();

    }

}
