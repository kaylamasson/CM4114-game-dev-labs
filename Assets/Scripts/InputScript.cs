using UnityEngine;

public class InputScript : MonoBehaviour {
    
    public KeyCode actionKey = KeyCode.E;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyUp(actionKey) && GetComponent<Animator>().GetFloat("Speed") < 0.1f) {
            GetComponent<Animator>().SetTrigger("Cheer");
        }
    }
}
