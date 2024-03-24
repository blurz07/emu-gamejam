using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class enemyaistop : MonoBehaviour
{
    private AIPath aipath;
    public Transform target;
    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        aipath = GetComponent<AIPath>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Vector3.Distance(transform.position,target.position) > 35f)
        {
                aipath.canMove = false;
        }
        else
        {
            aipath.canMove=true;
        }
    }
}
