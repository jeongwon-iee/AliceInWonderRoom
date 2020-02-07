using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCtrl : MonoBehaviour {

    InputSave inputsave;

	// Use this for initialization
	void Start () {
        inputsave = GameObject.Find("Input").GetComponent<InputSave>();
    }

// Update is called once per frame
void Update () {//blue red green 순서

//        Debug.Log("save_color0" + inputsave.save_color[0]);
//        Debug.Log("save_color1" + inputsave.save_color[1]);
//        Debug.Log("save_color2" + inputsave.save_color[2]);
        if (inputsave.save_color[0] && inputsave.save_color[1] && inputsave.save_color[2])
            GameObject.Find("Paint").GetComponent<MeshRenderer>().material.color = new Color(1f, 1f, 1f, 0.7f);
        else {
            if (inputsave.save_color[0] && inputsave.save_color[1])
                GameObject.Find("Paint").GetComponent<MeshRenderer>().material.color = new Color(1f, 0f, 1f, 0.7f);
            else if (inputsave.save_color[2] && inputsave.save_color[1])
                GameObject.Find("Paint").GetComponent<MeshRenderer>().material.color = new Color(1f, 1f, 0f, 0.7f);
            else if (inputsave.save_color[0] && inputsave.save_color[2])
                GameObject.Find("Paint").GetComponent<MeshRenderer>().material.color = new Color(0f, 1f, 1f, 0.7f);
            else {
                if (inputsave.save_color[0])
                    GameObject.Find("Paint").GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 1f, 0.7f);
                else if (inputsave.save_color[1])
                    GameObject.Find("Paint").GetComponent<MeshRenderer>().material.color = new Color(1f, 0f, 0f, 0.7f);
                else if (inputsave.save_color[2])
                    GameObject.Find("Paint").GetComponent<MeshRenderer>().material.color = new Color(0f, 1f, 0f, 0.7f);
                else
                    GameObject.Find("Paint").GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f, 0.7f);
            }
        }
	}
}
