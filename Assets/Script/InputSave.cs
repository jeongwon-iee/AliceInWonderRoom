using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSave : MonoBehaviour
{

    private PlayerControl playerctrl;
    int num;
    float[] x_pos = new float[] { -0.3f, 0f, 0.3f };
    public bool[] save_color = new bool[] { false, false, false };
    float y_pos;
    public bool[] save_lever = new bool[] { false, false, false, false }; //false == up / true == down
    float ly_pos;

    // Use this for initialization
    void Start()
    {
        playerctrl = GameObject.Find("CardboardMain").GetComponent<PlayerControl>();
        float[] x_pos = new float[] { -0.3f, 0f, 0.3f };
        //blue red green 순서
        float y_pos = -0.6f;
        float ly_pos = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        playerctrl = GameObject.Find("CardboardMain").GetComponent<PlayerControl>();
        if (playerctrl.MagnetButton.Triggered)
        {
            if (playerctrl.hit_ob.CompareTag("InputButton"))
            {
                num = int.Parse(playerctrl.hit_ob.name[0].ToString());
                if (save_color[num] == false)
                {
                    y_pos = -0.45f;
                    save_color[num] = true;
                }
                else if (save_color[num] == true) {
                    y_pos = -0.6f;
                    save_color[num] = false;
                }
                playerctrl.hit_ob.transform.localPosition = new Vector3(x_pos[num], y_pos, 0.01f);


            }
            else if (playerctrl.hit_ob.name == "Lever_head") {
                num = int.Parse(playerctrl.hit_ob.transform.parent.name[0].ToString());
                if (save_lever[num] == false)
                {
                    ly_pos = -0.4f;
                    save_lever[num] = true;
                }
                else if (save_lever[num] == true)
                {
                    ly_pos = 0.4f;
                    save_lever[num] = false;
                }
                playerctrl.hit_ob.transform.localPosition = new Vector3(0, ly_pos, -0.8f);
            }
        }
    }
}
