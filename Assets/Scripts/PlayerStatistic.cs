using UnityEngine;
using UnityEngine.UI;

namespace CasinoRoyal
{
    public class PlayerStatistic : SingletonBase<PlayerStatistic>
    {
        [SerializeField] private Index TapeIndex;
        private int score = 0;
        [SerializeField] private Text textScore;
        [SerializeField] private Tape modelTape;
        private int countScore = 0;
        private int currentScore = 0;
        private void Start()
        {
            currentScore = PlayerPrefs.GetInt("SaveScore");
            countScore = currentScore;
            textScore.text = "Score: " + countScore.ToString();
        }
        private void Update()
        {
            UpdateStatistic();
            SaverStatistic();
        }
        private void SaverStatistic()
        {
            if(countScore > currentScore)
            {
                PlayerPrefs.SetInt("SaveScore", countScore);
            }
        }
        private void UpdateStatistic()
        {
            if (modelTape.Rb.angularVelocity == 0 && Player.Instance.Active == true)
            {
                score = TapeIndex.Score;
                countScore += score;
                textScore.text = "Score: " + countScore.ToString();
                score = 0;
                Player.Instance.IsActive(false);
            }
        }
    }
}