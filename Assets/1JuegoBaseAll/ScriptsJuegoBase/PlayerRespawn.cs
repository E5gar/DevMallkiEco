using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public float checkPointPosX, checkPointPosY;

    private void Start() {
        if(PlayerPrefs.GetFloat("checkPointPosX")!=0){
            transform.position=(new Vector2(PlayerPrefs.GetFloat("checkPointPosX"), PlayerPrefs.GetFloat("checkPointPosY")));
        }
    }

    public void ReachedCheckpoint(float x, float y){
        PlayerPrefs.SetFloat("checkPointPosX",x);
        PlayerPrefs.SetFloat("checkPointPosY",y);
    }

    public void ResetCheckpoint() {
        PlayerPrefs.DeleteKey("checkPointPosX");
        PlayerPrefs.DeleteKey("checkPointPosY");
}
}
