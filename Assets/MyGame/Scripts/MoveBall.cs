using UnityEngine;

public class MoveBall : MonoBehaviour
{
    //public GameObject PosBallTopLeft;
    //public GameObject PosBallTopRight;
    //public GameObject PosBallBottomLeft;
    //public GameObject PosBallBottomRight;

    [SerializeField] private GameObject[] ballPositions;
    [SerializeField] private GameObject Ball;

   public void MoveTheBall()
   {
       Debug.Log(Random.Range(0,1));
   }
}
