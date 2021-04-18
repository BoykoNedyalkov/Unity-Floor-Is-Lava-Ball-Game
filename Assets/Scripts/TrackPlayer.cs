using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    public GameObject playerObject;
    public Vector3 offset = new Vector3(0, 1, -1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerObject!= null)
        {
            transform.position = playerObject.transform.position;
        }
    }
}
