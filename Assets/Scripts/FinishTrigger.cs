using UnityEngine;

public class FinishTrigger : MonoBehaviour
{

    public GameObject completeLvlUI;

    void OnTriggerEnter2D() {

      completeLvlUI.SetActive(true);

    }

}
