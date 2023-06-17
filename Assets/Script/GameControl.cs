using UnityEngine;

public class GameControl : MonoBehaviour
{

    public NewBehaviourScript newBehaviourScript;

    // Start is called before the first frame update
    void Start()
    {

    }


    public void OnJumpClickDown()
    {
        if (newBehaviourScript.myJump == false)
        {
            newBehaviourScript.myJump = true;
        }
    }

    public void OnJumpClickUp()
    {
        if (newBehaviourScript.myJump == true)
        {
            newBehaviourScript.myJump = false;
        }
    }

    public void OnLeftClickDown()
    {
        if (newBehaviourScript.myLeft == false)
        {
            newBehaviourScript.myLeft = true;
        }
    }

    public void OnLeftClickUp()
    {
        if (newBehaviourScript.myLeft == true)
        {
            newBehaviourScript.myLeft = false;
            newBehaviourScript.keyInput = 0;
        }
    }

    public void OnRightClickDown()
    {
        if (newBehaviourScript.myRight == false)
        {
            newBehaviourScript.myRight = true;
        }
    }
    public void OnRightClickUp()
    {
        if (newBehaviourScript.myRight == true)
        {
            newBehaviourScript.myRight = false;
            newBehaviourScript.keyInput = 0;
        }
    }


}
