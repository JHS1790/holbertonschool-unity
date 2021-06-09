using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
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

        if(RotateAroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);
            Quaternion camUpAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * RotationsSpeed, Vector3.left);

            _cameraOffset = camTurnAngle * camUpAngle * _cameraOffset;
        }

        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer || RotateAroundPlayer)
            transform.LookAt(PlayerTransform);
	}
}
