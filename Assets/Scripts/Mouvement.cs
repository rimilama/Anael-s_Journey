using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Windows.Kinect;


public class Mouvement : MonoBehaviour {

    public PositionDetection PositionDetect;
    public Text Validation;
    //CameraSpacePoint posNeck;
    //CameraSpacePoint posHead;
    //CameraSpacePoint posMid;
    CameraSpacePoint posHandLeft;
    CameraSpacePoint posElbowLeft;
    public float multiplier = 1;
    float tempsStart = 0.0f;
    bool positionStart = false;
    bool positionEnd = false;

    // Use this for initialization
    void Start () {
      
    }

    // Update is called once per frame
    void Update () {
        if(this.name == "elbowleft")
        {
            posElbowLeft = PositionDetect.PositionElbowLeft();
            this.transform.position = new Vector3(posElbowLeft.X * multiplier, posElbowLeft.Y * multiplier);
        }
        else if(this.name == "handleft")
        {
            posHandLeft = PositionDetect.PositionHandLeft();
            this.transform.position = new Vector3(posHandLeft.X * multiplier, posHandLeft.Y * multiplier);

        }
        /*else if(this.name == "mid")
        {
            posMid = PositionDetect.PositionMid();
            this.transform.position = new Vector3(posMid.X * multiplier, posMid.Y * multiplier);
        }

        Debug.Log("cou : " + posHead.Y * multiplier);
        Debug.Log("main : " + posHandLeft.Y * multiplier);
        */

        if (posHandLeft.X < posElbowLeft.X && posHandLeft.Y > posElbowLeft.Y && positionEnd == false)
        {
            tempsStart = Time.time;
            positionStart = true;
            Validation.text = "HAUT";
        }
        if(posHandLeft.X > posElbowLeft.X && posHandLeft.Y > posElbowLeft.Y && positionStart == true && Time.time - tempsStart > 2)
        {
            positionStart = false;
            Validation.text = "RESET";
        }
        if(posHandLeft.X > posElbowLeft.X && posHandLeft.Y < posElbowLeft.Y && positionStart == true && Time.time-tempsStart < 2)
        {
            positionStart = false;
            positionEnd = true;
        }
        if(positionEnd == true)
        {
            Validation.text = "Bienvenue !";
            positionEnd = false;
        }

        //Debug.Log("END : " + positionEnd);
        //Debug.Log("START : " + positionStart);
    }
}
