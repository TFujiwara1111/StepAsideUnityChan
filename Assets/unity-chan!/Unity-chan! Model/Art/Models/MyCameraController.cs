using System.Collections;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    // Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unity ちゃんとカメラの距離
    private float difference;

    //Use this for initialization
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置（ｚ座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてカメラの位置を異動させる
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }
}
