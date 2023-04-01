
public class ScoreManager : Singleton<ScoreManager>
{
    public ScoreController ScoreController;
    public void ScoreUp()
    {
        ScoreController.AddScore(1);
    }
}