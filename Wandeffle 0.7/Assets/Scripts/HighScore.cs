using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	public GameObject highScore;
	private string link;
	void Start()
	{
		Network.proxyIP = "10.10.10.1";
		Network.proxyPort = 3128;
		Network.useProxy = true;
		link = "http://jamalnave1.16mb.com/index.php";
		StartCoroutine(GetHighScore(link));
	}
	
	IEnumerator GetHighScore(string url)
	{
		WWW jamal = new WWW(url);
		new WaitForSeconds(1f);
		yield return jamal;
		Debug.Log (jamal.text);
		highScore.GetComponent<Text>().text = "HighScore : " + jamal.text;
	}
}
