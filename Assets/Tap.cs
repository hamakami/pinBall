using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tap : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        //SetAngle(this.defaultAngle);
        
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            var toucth = Input.GetTouch(0);
            if (toucth.phase == TouchPhase.Began)
            {
                //タッチ開始
                Debug.Log("押した瞬間");

            }

            else if (toucth.phase == TouchPhase.Ended)
            {
                Debug.Log("離した瞬間");
                  
        }

            if (toucth.phase == TouchPhase.Moved)
            {
                Debug.Log("押しっぱなし");
            }
        }
      

    }
}