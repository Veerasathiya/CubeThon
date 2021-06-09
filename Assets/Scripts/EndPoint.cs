using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
