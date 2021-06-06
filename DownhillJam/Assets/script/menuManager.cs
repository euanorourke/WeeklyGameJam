using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menuManager : MonoBehaviour
{
    public Button playButton;
    // Start is called before the first frame update
    void Start()
    {
        Button playBtn = playButton.GetComponent<Button>();
        playBtn.onClick.AddListener(Play);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Play()
    {
        SceneManager.LoadScene("Level1");
    }

}
