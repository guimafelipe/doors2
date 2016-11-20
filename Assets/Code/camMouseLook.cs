using UnityEngine;
using System.Collections;

public class camMouseLook : MonoBehaviour {

    Vector2 mouseLook = Vector2.zero;
	Vector2 smoothV = Vector2.zero;

    public float lookSensitivity = 1.0f;

	GameObject character;

	// Use this for initialization
	void Start () {
		character = transform.parent.gameObject;
	}

    // Update is called once per frame
    void Update() {
        DoRotation();
    }

    void DoRotation () {

        float yRot = Input.GetAxisRaw("Mouse X")*lookSensitivity;
            
        float xRot = Input.GetAxisRaw ("Mouse Y")*lookSensitivity; //Get the mouse input

        Vector3 _yRotation = new Vector3(0f, yRot, 0f);
        Vector3 _xRotation = new Vector3(xRot, 0f, 0f);
		transform.localRotation = transform.localRotation * Quaternion.Euler(-_xRotation);
		character.transform.localRotation = character.transform.localRotation * Quaternion.Euler(_yRotation);
    }

    void ResetRotation(Quaternion _doorRotation) {
        transform.localRotation = _doorRotation;
    }

}
