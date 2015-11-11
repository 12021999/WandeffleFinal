using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ScoreGameover : MonoBehaviour {

	public GameObject Scoregameover;
	private string url;
	
	void Start () 
	{
		url = "http://jamalnave1.16mb.com/Conecta.php";
		SetScoreToData();
	}
	
	void Update () 
	{
		int scoregameover = PlayerPrefs.GetInt("Player Score");
		Scoregameover.GetComponent<Text>().text = "Score : " + scoregameover.ToString();
	}
	void SetScoreToData()
	{
		WWWForm rada = new WWWForm();
		rada.AddField("score",PlayerPrefs.GetInt("Player Score"));
		
		WWW www = new WWW(url,rada);
	}
}
