using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rg;
    public bool myJump = false;
    public bool myLeft = false;
    public bool myRight = false;

    public float keyInput=0.0f;



    // Update is called once per frame
    void Update()
    {
        if (myJump)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up /2, ForceMode.VelocityChange);

        }


        if (myLeft)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(keyInput * 3, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        }

        if (myRight)
        {
            if (keyInput < 3) keyInput += 0.09f;
            if (keyInput > 3) keyInput = 3.0f;

            GetComponent<Rigidbody>().velocity = new Vector3(keyInput, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*3, ForceMode.VelocityChange);
        }

        
    }
}
