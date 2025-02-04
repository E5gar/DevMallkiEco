using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class invocarJefe : MonoBehaviour
{
    private bool isMoving = false;          
    private Vector3 targetPosition;        
    private float moveSpeed = 1.3f;          
    private float horizontalAmplitude = 0.05f;   
    private float horizontalFrequency = 100f;     

    public void subirJefe()
    {
        if (!isMoving)
        {
            targetPosition = transform.position + new Vector3(0f, 6f, 0f);
            isMoving = true;
        }
    }

    private void Update()
    {
        if (isMoving)
        {
            float step = moveSpeed * Time.deltaTime;

            if (transform.position.y < targetPosition.y)
            {
                float horizontalOffset = Mathf.Sin(Time.time * horizontalFrequency) * horizontalAmplitude;
                transform.position = new Vector3(transform.position.x + horizontalOffset, transform.position.y, transform.position.z);
            }

            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

            if (transform.position.y >= targetPosition.y)
            {
                transform.position = new Vector3(125f, targetPosition.y, targetPosition.z);
                isMoving = false;
            }
        }
    }
}
