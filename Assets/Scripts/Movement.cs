using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed;
    public GameObject light;
    public Vector3 mousePos;
    public LayerMask mouseLayer;

    public Animator anim;
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        RaycastHit mouseHit;

        if (Physics.Raycast (ray,out mouseHit,Mathf.Infinity, mouseLayer,QueryTriggerInteraction.Ignore)) {
            mousePos = mouseHit.point;
            mousePos.y = light.transform.position.y;
        }
        transform.LookAt (mousePos, Vector3.up);

        float x = Input.GetAxis ("Horizontal");
        float z = Input.GetAxis ("Vertical");

        transform.Translate (new Vector3 (x, 0, z) * Time.deltaTime * speed);

        anim.SetFloat("Horizontal_f", x);
        anim.SetFloat("Vertical_f", z);

    }
}