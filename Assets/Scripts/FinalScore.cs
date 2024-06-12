using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text MaxScore;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       MaxScore.text = PlayerPrefs.GetFloat("HighScore").ToString();
        Score.text = PlayerPrefs.GetFloat("CurrentScore").ToString() ;
    }
}
