using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float CurrentScore;
    float HighScore;
    float scoreIncTime = 1f;
    float timePassed;
    float scorePoint = 1f;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("CurrentScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > scoreIncTime)
        {
            scoreInc(scorePoint);
            timePassed = 0;
        }

        if(PlayerPrefs.GetFloat("CurrentScore") > PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", CurrentScore);
        }
        
    }
    public void scoreInc(float Point)
    {
        CurrentScore += Point;
        ScoreText.text = CurrentScore.ToString();
        PlayerPrefs.SetFloat("CurrentScore", CurrentScore);
    }
}
