using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Windows.Kinect;


public class PositionDetection : MonoBehaviour {

    public GameObject BodySrcManager;
    public JointType TrackedHead;
    public JointType TrackedNeck;
    public JointType TrackedHandLeft;
    public JointType TrackedElbowLeft;
    public JointType TrackedHandRight;
    public JointType TrackedMid;
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
        CameraSpacePoint pos = new CameraSpacePoint();

        foreach (var body in bodies)
        {
            if (body == null)
            {
                pos.X = 0.0f;
                pos.Y = 0.0f;
                pos.Z = 0.0f;
            }
            else if (body.IsTracked)
            {
                pos = body.Joints[TrackedHead].Position;
                return pos;
            }
        }

        return pos;
    }

    public CameraSpacePoint PositionNeck()
    {
        CameraSpacePoint pos = new CameraSpacePoint();

        foreach (var body in bodies)
        {
            if (body == null)
            {
                pos.X = 0.0f;
                pos.Y = 0.0f;
                pos.Z = 0.0f;
            }
            else if (body.IsTracked)
            {
                pos = body.Joints[TrackedNeck].Position;
                return pos;
            }
        }

        return pos;
    }

    public CameraSpacePoint PositionHandRight()
    {
        CameraSpacePoint pos = new CameraSpacePoint();

        foreach (var body in bodies)
        {
            if (body == null)
            {
                pos.X = 0.0f;
                pos.Y = 0.0f;
                pos.Z = 0.0f;
            }
            else if (body.IsTracked)
            {
                pos = body.Joints[TrackedHandRight].Position;
                return pos;
            }
        }

        return pos;
    }

    public CameraSpacePoint PositionHandLeft()
    {
        CameraSpacePoint pos = new CameraSpacePoint();

        foreach (var body in bodies)
        {
            if (body == null)
            {
                pos.X = 0.0f;
                pos.Y = 0.0f;
                pos.Z = 0.0f;
            }
            else if (body.IsTracked)
            {
                pos = body.Joints[TrackedHandLeft].Position;
                return pos;
            }
        }

        return pos;
    }

    public CameraSpacePoint PositionElbowLeft()
    {
        CameraSpacePoint pos = new CameraSpacePoint();

        foreach (var body in bodies)
        {
            if (body == null)
            {
                pos.X = 0.0f;
                pos.Y = 0.0f;
                pos.Z = 0.0f;
            }
            else if (body.IsTracked)
            {
                pos = body.Joints[TrackedElbowLeft].Position;
                return pos;
            }
        }

        return pos;
    }

    public CameraSpacePoint PositionMid()
    {
        CameraSpacePoint pos = new CameraSpacePoint();

        foreach (var body in bodies)
        {
            if (body == null)
            {
                pos.X = 0.0f;
                pos.Y = 0.0f;
                pos.Z = 0.0f;
            }
            else if (body.IsTracked)
            {
                pos = body.Joints[TrackedMid].Position;
                return pos;
            }
        }

        return pos;
    }
}
