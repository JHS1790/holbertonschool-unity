using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool isInverted;
    public Transform PlayerTransform;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 1.0f;

    public bool LookAtPlayer = true;

    public bool RotateAroundPlayer = true;

    public float RotationsSpeed = 3.0f;

	void Start () {
        _cameraOffset = transform.position - PlayerTransform.position;
	}
	

	void LateUpdate () {

        Quaternion camTurnAngle, camUpAngle;

        if (PlayerPrefs.GetInt("isInverted") == 1)
        {
            isInverted = true;
        }
        else
        {
            isInverted = false;
        }

        if(isInverted)
        {
            camUpAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * RotationsSpeed, Vector3.right);
        }
        else
        {
            camUpAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * RotationsSpeed, Vector3.left);
        }
        camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);

        _cameraOffset = camTurnAngle * camUpAngle * _cameraOffset;

        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer || RotateAroundPlayer)
            transform.LookAt(PlayerTransform);
	}
}
