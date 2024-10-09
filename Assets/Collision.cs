using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public gameOver gameOverUI;
    public YouWin WinUI;        

    void OnCollisionEnter(Collision collisionInfo)
    {
        string collidedObjectName = collisionInfo.gameObject.name;

        if (collidedObjectName == "Lose1" || collidedObjectName == "Lose2")
        {

            gameOverUI.Setup();

        }

        if (collidedObjectName == "Win1")
        {

            WinUI.Setup();

        }
    }
}