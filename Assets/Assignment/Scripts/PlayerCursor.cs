using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCursor : MonoBehaviour
{
    public float speed = 5f;
    Animator cursorAnimator; 
    void Start()
    {
        cursorAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        transform.position = Vector3.Lerp(transform.position, mousePos, speed * Time.deltaTime);
        if (Input.GetMouseButtonUp(0))
        {
            cursorAnimator.SetTrigger("Shot");
        }
    }
}
