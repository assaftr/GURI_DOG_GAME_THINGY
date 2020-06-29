using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public float jumpforce = 10f;


    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        bool w = Input.GetKey(KeyCode.W);
        bool a = Input.GetKey(KeyCode.A);
        bool d = Input.GetKey(KeyCode.D);
        bool s = Input.GetKey(KeyCode.S);
        bool space = Input.GetKey(KeyCode.Space);

        if (w)
        {
            Vector3 tempVect = new Vector3(0, 0, 1);
            tempVect = tempVect.normalized * speed * Time.deltaTime;
            rb.MovePosition(transform.position + tempVect);
        }
        if (a)
        {
            Vector3 tempVect = new Vector3(-1, 0, 0);
            tempVect = tempVect.normalized * speed * Time.deltaTime;
            rb.MovePosition(transform.position + tempVect);
        }
        if (d)
        {
            Vector3 tempVect = new Vector3(1, 0, 0);
            tempVect = tempVect.normalized * speed * Time.deltaTime;
            rb.MovePosition(transform.position + tempVect);
        }
        if (s)
        {
            Vector3 tempVect = new Vector3(0, 0, -1);
            tempVect = tempVect.normalized * speed * Time.deltaTime;
            rb.MovePosition(transform.position + tempVect);
        }
        if (space)
        {

            Vector3 tempVect = new Vector3(0, jumpforce, 0);
            tempVect = tempVect.normalized * jumpforce * Time.deltaTime;
            rb.MovePosition(transform.position + tempVect);
        }
    }
}
