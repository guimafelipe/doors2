using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 10.0F;
	public bool inPortal = false;
    // Use this for initialization

    private bool onEsc = false;

	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}

    void Update() {
        DoTranslation();
        DoRotation();

        if (Input.GetKeyDown("escape")) {
            if (!onEsc) {
                Cursor.lockState = CursorLockMode.None;
                onEsc = true;
                Debug.Log("Entrou no esc");
            } else {
                Cursor.lockState = CursorLockMode.Locked;
                onEsc = false;
                Debug.Log("Saiu do esc");
            }
        }
    }

	// Update is called once per frame
	void DoTranslation () {
		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, translation);
	}

    void DoRotation() {


    }



}