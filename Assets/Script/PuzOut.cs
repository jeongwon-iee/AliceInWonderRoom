using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzOut : MonoBehaviour {

    //Lever 정답을 up down down up이라 하자
    public bool[] puzout = new bool[] { false, true, true, false };
    InputSave inputsave;
    GameObject puz;
    bool flag;
    public bool Solve(bool[] save, bool[] puzout)
    {
        for (int i = 0; i < 3; i++)
        {
            if (save[i] != puzout[i])
            {
                return false;
                break;
            }
        }
        return true;
    }

    // Use this for initialization
    void Start () {
        flag = true;
        GameObject[] puz = GameObject.FindGameObjectsWithTag("puz");
        inputsave = GameObject.Find("Input").GetComponent<InputSave>();
        for (int i = 0; i < puz.Length; i++) {
            puz[i].SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
        inputsave = GameObject.Find("Input").GetComponent<InputSave>();
        if (Solve(inputsave.save_lever, puzout) && flag) {
            for (int i = 0; i < 5; i++) {
                GameObject.Find("floor").transform.Find("puz"+i.ToString()).gameObject.SetActive(true);
            }
            flag = false;
        }
	}
}
