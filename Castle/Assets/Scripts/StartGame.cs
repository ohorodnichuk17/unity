using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
	public Button startButton; // Reference to your UI button

	private void Start()
	{
		// Make sure to assign the button in the Inspector
		startButton.onClick.AddListener(StartGameScene);
	}

	private void StartGameScene()
	{
		// Load the "Main_Scene"
		SceneManager.LoadScene("Main_Scene");
	}
}
