using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;

public class LeadBoard : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> nombres;
    [SerializeField] private List<TextMeshProUGUI> puntajes;

    public GameObject MostrarLeaderBoard;

    private string publicLeaderboardKey = "3584bff5d8f613adbe2b1f973352c3fdf29172e8c499e2542e98dab6377208d6";

    private void Start() {
        MostrarLeaderBoard.SetActive(false);
        GetLeaderboard();
    }

    public void MostrarLeader(){
        MostrarLeaderBoard.SetActive(true);
    }


    public void GetLeaderboard(){
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) =>{
            
            int loopLength = (msg.Length < nombres.Count) ? msg.Length : nombres.Count;

            for (int i = 0; i < loopLength; ++i) {
                nombres[i].text = msg[i].Username;
                puntajes[i].text = msg[i].Score.ToString();
            }


        }));
    }

    public void SetLeaderboardEntry(string username, int score){
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username, score, ((msg) =>{
            //if (System.Array.IndexOf (badWords, name) != -1) return;
            GetLeaderboard();

        Debug.Log("EL PUNTAJE ENVIADO ES: " + username);
        Debug.Log("EL NOMBRE ENVIADO ES: " + score);

        }));
    }



}
