using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public EnemyState currentState;

    public float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.Patroling;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState.ToString());
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = EnemyState.Attacking;
        }

        timer += Time.deltaTime;
        if (timer >= 5 && currentState == EnemyState.Patroling)
        {
            currentState = EnemyState.Chasing;
        }
        
        if (timer >= 100)
        {
            currentState = EnemyState.Death;
            Destroy(gameObject, 0.1f);
        }
    }
    
    public enum EnemyState
    {
        Patroling,
        Attacking,
        Chasing,
        Death
    }
}
