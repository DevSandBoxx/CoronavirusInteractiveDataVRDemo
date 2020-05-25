using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Move : MonoBehaviour
{
    public float speed = 10f;
    private float sideMov;
    private float forwardMov;
    private Vector3 position = Vector3.zero;
    public Rigidbody rb;
    void Update()
    {

        //float x = GvrControllerInput.TouchPos.x;
        //float y = GvrControllerInput.TouchPos.y;

        //if (GvrControllerInput.TouchDown)
        //{
        //    touchPadDown = true;
        //}
        //if (GvrControllerInput.TouchUp)
        //{
        //    touchPadUp = true;
        //}

        //canvasText.text = "(" + x + ", " + y + ")";
        if (GvrControllerInput.TouchPos.y < 0.5 && GvrControllerInput.TouchPos.x < 0.7 && GvrControllerInput.TouchPos.x > 0.3)
        {
            //canvasText.text = "TOP";
            forwardMov = 1f;
            sideMov = 0f;
        }
        else if (GvrControllerInput.TouchPos.y > 0.5 && GvrControllerInput.TouchPos.x < 0.7 && GvrControllerInput.TouchPos.x > 0.3)
        {
            //canvasText.text = "Bottom";
            forwardMov = -1f;
            sideMov = 0f;
        }
        else if (GvrControllerInput.TouchPos.x < 0.5 && GvrControllerInput.TouchPos.y < 0.7 && GvrControllerInput.TouchPos.y > 0.3)
        {
            //canvasText.text = "LEFT";
            sideMov = -1f;
            forwardMov = 0;
        }
        else if (GvrControllerInput.TouchPos.x > 0.5 && GvrControllerInput.TouchPos.y < 0.7 && GvrControllerInput.TouchPos.y > 0.3)
        {
            //canvasText.text = "RIGHT";
            sideMov = 1f;
            forwardMov = 0;
        }
        else
        {
            sideMov = forwardMov = 0;
        }

        //    forwardMov = GvrControllerInput.TouchPos.y;
        //}
        //else
        //{
        //    sideMov = forwardMov = 0;
        //}

        if (GvrControllerInput.ClickButton)
        {
            position = (Camera.main.transform.forward * forwardMov + transform.right * sideMov).normalized * speed;
        }
        else
        {
            position = Vector3.zero;
        }

        rb.AddForce(position * Time.deltaTime);



    }

}
