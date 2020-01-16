using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Windows.Kinect;


public class PositionDetection : MonoBehaviour {

    public GameObject BodySrcManager;
    public JointType TrackedHead;
    public JointType TrackedHandLeft;
    public JointType TrackedHandRight;
    private Kinect bodyManager;
    private Body[] bodies;
    public float multiplier = 1;

    // Use this for initialization
    void Start () {
        bodyManager = BodySrcManager.GetComponent<Kinect>();
    }
	
	// Update is called once per frame
	void Update () {
        bodies = bodyManager.GetData();
    }

   public CameraSpacePoint PositionHead()
    {
        CameraSpacePoint pos;
        pos.X = 1;
        foreach (var body in bodies)
        {
            if (body.IsTracked)
            {
                pos = body.Joints[TrackedHead].Position;
                
            }
        }
        return pos;
    }
}
