using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //[SerializeField] private float speed = 0f;
    //[SerializeField] private string name;

    public float Speed
    {
        //get { return speed; }
        get;
        private set;
    }
    
    public string Name
    {
        /*get { return name; }
        set { name = value; }*/

        get;
        set;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //speed = 5f;
        Speed = 5f;
        //name = "JL";
        Name = "JL";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //speed++;
            Speed++;
        }
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            //speed--;
            Speed--;
        }
    }
}
