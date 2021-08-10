using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CircleMotion : MonoBehaviour
{
    
    public float speed;
    public List<GameObject> movePoints;
    private Vector3 point1;
    private Vector3 point2;
    private bool pointReached;
    public Vector3 targetPosition;



    // Start is called before the first frame update
    void Start()
    {
        movePoints.AddRange(GameObject.FindGameObjectsWithTag("MovePoint"));
        point1 = movePoints[0].transform.position;
        point2 = movePoints[1].transform.position;
        targetPosition = point1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, point1) < 0.1)
        {
            
            targetPosition = point2;
        }

      
        if (Vector3.Distance(transform.position, point2) < 0.1)
        {
            
            targetPosition = point1;
        }

        
        float step = speed * Time.deltaTime;

        
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
        

        

        //transform.position = Vector3.MoveTowards(transform.position, point1, step);
    }
}
