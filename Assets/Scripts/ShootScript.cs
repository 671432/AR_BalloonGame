using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{

    public Camera arCamera;
    public GameObject popSoundObject;
    int score;
    public Text scoreText;

    public void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if(hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon2(Clone)" || hit.transform.name == "balloon3(Clone)")
            {
                Destroy(hit.transform.gameObject);

                Instantiate(popSoundObject);

                score += 1;
                scoreText.text = score + "";
            }
        }
        
    }
}
