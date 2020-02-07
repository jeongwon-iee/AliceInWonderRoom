using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    float y; //postion y값

    public Image CursorGageImage;

    public Cardboard MagnetButton; //Cardboard 스크립트를 저장하는 변수

    private Vector3 ScreenCenter;

    public GameObject hit_ob;

    private float GageTimer;


	// Use this for initialization
	void Start () {
        ScreenCenter = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
        //메인카메라 화면의 높이/2=x좌표,넓이/2 y좌표=카메라중앙좌표
        MagnetButton = GetComponent<Cardboard>();
        //MagnetButton변수에 현재 오브젝트가 가지고 있는 카드보드스크립트를 불러와 저장한다.
    }

    // Update is called once per frame
    void Update () {
        Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);
        RaycastHit hit;
        CursorGageImage.fillAmount = GageTimer;

        if(Physics.Raycast(ray, out hit, 100.0f))
        {
            hit_ob = hit.collider.gameObject;
            //if (hit.collider.CompareTag("InputButton")) {
              //  if (MagnetButton.Triggered) {
                    //hit.collider.gameObject.transform.localPosition = new Vector3(gameObject.transform.position.x, y, 0.01f);
        
        }
	}
}
