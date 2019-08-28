using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPointShow : MonoBehaviour
{
	//スコアを表示するテキスト
	private GameObject GetPointText;
	private int score = 0; //スコア計算用変数

    // Start is called before the first frame update
    void Start()
    {
		//シーン中のGetPointTextオブジェクトを取得
		this.GetPointText = GameObject.Find("GetPointText");
		score   = 0;
		SetScore();   //初期スコアを代入して表示
    }

    //小さい星と雲に衝突で＋100、大きい星と雲に衝突で＋200
    void OnCollisionEnter(Collision collision)
    {
        string Tag = collision.gameObject.tag;

		//Debug.Log (collision.gameObject.name);

		if ((Tag == "LargeStarTag")||(Tag=="LargeCloudTag"))
        {
			Debug.Log (collision.gameObject.name);
            score += 200;
			//Destroy(collision.gameObject);
        }
		else if(Tag == "SmallCloudTag")
        {
			Debug.Log (collision.gameObject.name);
            score += 100;
			//Destroy(collision.gameObject);
        }
		/*else if(Tag == "SmallCloudTag")
		{
			score += 100;
            //Destroy(gameObject);
        }
        else if (Tag == "SmallCloudPrefabTag")
        {
            score += 100;
            //Destroy(gameObject);
        }
        else if (Tag == "LargeCloudTag")
        {
            score += 200;
            //Destroy(gameObject);
        }*/
        SetScore();
        
    }

    void SetScore()
	{
		//GetPointTextにスコアを表示
		this.GetPointText.GetComponent<Text>().text = "Score:"+score;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
